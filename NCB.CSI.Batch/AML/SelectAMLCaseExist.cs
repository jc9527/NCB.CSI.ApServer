using NCB.CSI.Models.CSI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace NCB.CSI.Batch.AML
{
    class SelectAMLCaseExist
    {
        string connection = string.Empty;
        public SelectAMLCaseExist()
        {
            connection = ConfigurationManager.ConnectionStrings["WebTM"].ConnectionString;
        }

        public async Task<CampaignTasksRs> SelectAMLCaseExistAsync(CampaignTasksRq model)
        {
            string campaignCode = ConfigurationManager.AppSettings["AML.CampaignCode"];
            var sql = "select TaskId from CampaignTasks where campaignCode = @campaignCode and CustID = @CustID and CreatedAt >= @CreatedAt";
            var parameters = new
            {
                campaignCode = campaignCode,
                CustID = model.CustId,
                CreatedAt = DateTime.Today
            };
            using (var cn = new SqlConnection(connection))
            {
                var rs = new CampaignTasksRs();
                var query = await cn.QueryAsync<CampaignTasksRq>(sql, parameters);
                rs.AffectedRowCount = query.Count();
                return rs;
            }
        }
    }
}
