using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Devpro.Models;
using NCB.CSI.Models.CSI;
using Newtonsoft.Json;
using NLog;

namespace NCB.CSI.Batch.WTM
{
    class SyncCampaignTasks
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        string connection = string.Empty;
        public SyncCampaignTasks()
        {
            connection = ConfigurationManager.ConnectionStrings["WebTM"].ConnectionString;
        }

        public async Task<int> SyncCampaignTasksAsync(int count)
        {
            IEnumerable<CampaignTasksRq> query;
            while (true)
            {
                using (var cn = new SqlConnection(connection))
                    query = await cn.QueryAsync<CampaignTasksRq>("sp_CampaignTasks_SyncFetch", new { count = count }, commandType: CommandType.StoredProcedure);
                _logger.Info($"Sync sp_CampaignTasks_SyncFetch->Total Count:{query.Count()}");
                if (!query.Any())
                    break;
                foreach (var item in query)
                {
                    using (var client = new HttpClient())
                    {
                        Dictionary<string, string> data = new Dictionary<string, string>()
                        {
                            { "EstmateID", item.TaskTag1 },
                            { "TCDate", (item.LastContactDate == null) ? string.Empty : item.LastContactDate.ToString("yyyy/MM/dd HH:mm")},
                            { "TCMember", item.ResultCode },
                            { "Memo", item.Note },
                        };
                        var jsonReq = JsonConvert.SerializeObject(data);
                        var req = new HttpRequestMessage(HttpMethod.Post, ConfigurationManager.AppSettings["SetCRMRst"])
                        {
                            Content = new StringContent(jsonReq, Encoding.UTF8, "application/json")
                        };

                        var response = await client.SendAsync(req);
                        if(!response.IsSuccessStatusCode)
                            _logger.Info($"Sync SetCRMRst API->HTTP Status:{response.StatusCode}");
                        var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content.ReadAsStringAsync().Result);
                        var responseCode = result["ResponseCode"];
                        var responseMSG = result["ResponseMSG"];
                        _logger.Info($"Sync SetCRMRst API->{JsonConvert.SerializeObject(data)}, APIResponse:{JsonConvert.SerializeObject(result)}");
                        using (var cn = new SqlConnection(connection))
                        {
                            int SyncStatus = 2;
                            if (responseCode == "00")
                                SyncStatus = 3;
                            var AffectedRowCount = await cn.ExecuteAsync("sp_CampaignTasks_SyncUpdate", new { TaskId = item.TaskId, SyncStatus = SyncStatus, SyncErrorMsg = responseMSG }, commandType: CommandType.StoredProcedure);
                            if(AffectedRowCount == 1)
                                _logger.Info($"Sync sp_CampaignTasks_SyncUpdate->Success");
                            else
                                _logger.Info($"Sync sp_CampaignTasks_SyncUpdate->Error");
                        }
                    }
                }
               break;
            }
            return 0;
        }

        public async Task<int> SyncCampaignTasksNotDialAsync(string campaignCode)
        {
            IEnumerable<CampaignTasksRq> query;
            using (var cn = new SqlConnection(connection))
            {
                var array = campaignCode.Split(',');
                string sql = $"select * from CampaignTasks where ResultCode is null and CreatedAt < getdate() and CampaignCode in @CampaignCode";
                query = await cn.QueryAsync<CampaignTasksRq>(sql, new { CampaignCode = array });
                query = query.Where(c => Convert.ToDateTime(c.Data30) < DateTime.Today.AddDays(1));
            }
            _logger.Info($"Sync CampaignTasksNotDial->Total Count:{query.Count()}");
            if (query.Any())
            {
                foreach (var item in query)
                {
                    using (var client = new HttpClient())
                    {
                        Dictionary<string, string> data = new Dictionary<string, string>()
                        {
                            { "EstmateID", item.TaskTag1 },
                            { "TCDate", Convert.ToDateTime(item.Data30).ToString("yyyy/MM/dd HH:mm") },
                            { "TCMember", "09" },
                            { "Memo", item.Note },
                        };
                        var jsonReq = JsonConvert.SerializeObject(data);
                        var req = new HttpRequestMessage(HttpMethod.Post, ConfigurationManager.AppSettings["SetCRMRst"])
                        {
                            Content = new StringContent(jsonReq, Encoding.UTF8, "application/json")
                        };

                        var response = await client.SendAsync(req);
                        if (!response.IsSuccessStatusCode)
                            _logger.Info($"Sync SetCRMRst API->HTTP Status:{response.StatusCode}");
                        var result = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content.ReadAsStringAsync().Result);
                        var responseCode = result["ResponseCode"];
                        var responseMSG = result["ResponseMSG"];
                        _logger.Info($"Sync SetCRMRst API->{JsonConvert.SerializeObject(data)}, APIResponse:{JsonConvert.SerializeObject(result)}");
                        using (var cn = new SqlConnection(connection))
                        {
                            int SyncStatus = 2;
                            if (responseCode == "00")
                                SyncStatus = 3;
                            string sql = "update CampaignTasks set ResultType = 4, ResultCode = '09', ResultDesc = N'未撥打', SyncFlag = @SyncFlag, SyncTime = getdate(), SyncErrMsg = @SyncErrMsg where TaskId = @TaskId";
                            var AffectedRowCount = await cn.ExecuteAsync(sql, new { TaskId = item.TaskId, SyncFlag = SyncStatus, SyncErrMsg = responseMSG });
                            if (AffectedRowCount == 1)
                                _logger.Info($"Sync CampaignTasksNotDial->Success");
                            else
                                _logger.Info($"Sync CampaignTasksNotDial->Error");
                        }
                    }
                }
            }
            return 0;
        }
    }
}
