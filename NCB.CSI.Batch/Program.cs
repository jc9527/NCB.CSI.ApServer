using CommandLine;
using Devpro.Models;
using Devpro.Shared.Helpers;
using NCB.CSI.ApClient.Services.BMS.CreateAccount;
using NCB.CSI.ApClient.Services.BMS.Loan;
using NCB.CSI.ApClient.Services.CSI;
using NCB.CSI.Batch.AML;
using NCB.CSI.Batch.WTM;
using NCB.CSI.Models.BMS;
using NCB.CSI.Models.BMS.CreateAccount;
using NCB.CSI.Models.BMS.Loan;
using NCB.CSI.Models.CSI;
using Newtonsoft.Json;
using NLog;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NCB.CSI.Batch {
    class Program {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        static async Task<int> Main(string[] args) {
            try {
                //NLog.config設定動態LogFileName
                GlobalDiagnosticsContext.Set("LogFileName", args[0]);
                _logger.Info(JsonConvert.SerializeObject(args.Select(x => FortifyHelper.GetValidatedString(x))));
                var rc = await Parser.Default.ParseArguments<GetCaseListOptions, GetLoanInfoOptions, GetAmlCasesOptions, GetAmlBlackCasesOptions, GetWTMInsuranceCasesOptions, SyncTMInsuranceCasesOptions, SyncWTMInsuranceCasesNotDialOptions, GetWTMLoanCasesOptions>(args)
                    .MapResult(
                        (GetCaseListOptions opts) => GetCaseList(opts),
                        (GetLoanInfoOptions opts) => GetLoanInfo(opts),
                        (GetAmlCasesOptions opts) => GetAmlCases(opts),
                        (GetAmlBlackCasesOptions opts) => GetAmlBlackCases(opts),//SyncTMInsuranceCasesOptions
                        (GetWTMInsuranceCasesOptions opts) => GetWTMInsuranceCases(opts),
                        (SyncTMInsuranceCasesOptions opts) => SyncWTMInsuranceCases(opts),
                        (SyncWTMInsuranceCasesNotDialOptions opts) => SyncWTMInsuranceCasesNotDial(opts),
                        (GetWTMLoanCasesOptions opts) => GetWTMLoanCases(opts),
                        errs => Task.FromResult(-1)
                    );
            }
            catch (Exception e) {
                _logger.Error(e);
            }
            return -99;
        }

        [Verb("GetCaseList", HelpText = "Import Application Cases")]
        class GetCaseListOptions {
            [Option("casestatus", Required = true, HelpText = "Case Status")]
            public string casestatus { get; set; }
            [Option("from", Required = true, HelpText = "From Minutes (difference from now)")]
            public int from { get; set; }
            [Option("to", Required = true, HelpText = "To Minutes (difference from now)")]
            public int to { get; set; }
            [Option("campaign", Required = true, HelpText = "Campaign Code")]
            public string campaign { get; set; }
            [Option("wave", Required = true, HelpText = "Wave Code")]
            public string wave { get; set; }
            [Option("department", Required = true, HelpText = "Department Code")]
            public string department { get; set; }
        }

        [Verb("GetLoanInfo", HelpText = "Import Loan Cases")]
        class GetLoanInfoOptions {
            [Option("campaign", Required = true, HelpText = "Campaign Code")]
            public string campaign { get; set; }
            [Option("wave", Required = true, HelpText = "Wave Code")]
            public string wave { get; set; }
            [Option("department", Required = true, HelpText = "Department Code")]
            public string department { get; set; }
        }

        [Verb("GetAmlCases", HelpText = "Import AML Cases")]
        class GetAmlCasesOptions
        {
            [Option("host", Required = true, HelpText = "SFTP Host")]
            public string host { get; set; }
            [Option("username", Required = true, HelpText = "SFTP User Id")]
            public string username { get; set; }
            [Option("password", Required = true, HelpText = "SFTP Password")]
            public string ppwwdd { get; set; }
            [Option("filepath", Required = true, HelpText = "SFTP File Path")]
            public string filepath { get; set; }
            [Option("prefix", Required = true, HelpText = "File Name Prefix")]
            public string prefix { get; set; }
            [Option("extension", Required = true, HelpText = "File Extension")]
            public string extension { get; set; }
            [Option("datediff", Required = true, HelpText = "Date Difference")]
            public int datediff { get; set; }
            [Option("fieldCount", Required = true, HelpText = "Field Count")]
            public int fieldCount { get; set; }
            [Option("separator", Required = true, HelpText = "Field Separator")]
            public string separator { get; set; }
            [Option("campaign", Required = true, HelpText = "Campaign Code")]
            public string campaign { get; set; }
            [Option("wave", Required = true, HelpText = "Wave Code")]
            public string wave { get; set; }
            [Option("department", Required = true, HelpText = "Department Code")]
            public string department { get; set; }
        }

        [Verb("GetAmlBlackCases", HelpText = "Import AML Black Cases")]
        class GetAmlBlackCasesOptions
        {
            [Option("host", Required = true, HelpText = "SFTP Host")]
            public string host { get; set; }
            [Option("username", Required = true, HelpText = "SFTP User Id")]
            public string username { get; set; }
            [Option("password", Required = true, HelpText = "SFTP Password")]
            public string ppwwdd { get; set; }
            [Option("filepath", Required = true, HelpText = "SFTP File Path")]
            public string filepath { get; set; }
            [Option("prefix", Required = true, HelpText = "File Name Prefix")]
            public string prefix { get; set; }
            [Option("extension", Required = true, HelpText = "File Extension")]
            public string extension { get; set; }
            [Option("datediff", Required = true, HelpText = "Date Difference")]
            public int datediff { get; set; }
            [Option("fieldCount", Required = true, HelpText = "Field Count")]
            public int fieldCount { get; set; }
            [Option("separator", Required = false, HelpText = "Field Separator")]
            public string separator { get; set; }
            [Option("campaign", Required = false, HelpText = "Campaign Code")]
            public string campaign { get; set; }
            [Option("wave", Required = true, HelpText = "Wave Code")]
            public string wave { get; set; }
            [Option("department", Required = true, HelpText = "Department Code")]
            public string department { get; set; }
        }

        [Verb("GetWTMInsuranceCases", HelpText = "Import WTM Insurance Cases")]
        class GetWTMInsuranceCasesOptions
        {
            [Option("host", Required = true, HelpText = "SFTP Host")]
            public string host { get; set; }
            [Option("username", Required = true, HelpText = "SFTP User Id")]
            public string username { get; set; }
            [Option("password", Required = true, HelpText = "SFTP Password")]
            public string ppwwdd { get; set; }
            [Option("filepath", Required = true, HelpText = "SFTP File Path")]
            public string filepath { get; set; }
            [Option("prefix", Required = true, HelpText = "File Name Prefix")]
            public string prefix { get; set; }
            [Option("extension", Required = true, HelpText = "File Extension")]
            public string extension { get; set; }
            [Option("datediff", Required = true, HelpText = "Date Difference")]
            public int datediff { get; set; }
            [Option("fieldCount", Required = true, HelpText = "Field Count")]
            public int fieldCount { get; set; }
            [Option("separator", Required = false, HelpText = "Field Separator")]
            public string separator { get; set; }
            [Option("campaign", Required = false, HelpText = "Campaign Code")]
            public string campaign { get; set; }
            [Option("wave", Required = true, HelpText = "Wave Code")]
            public string wave { get; set; }
            [Option("department", Required = true, HelpText = "Department Code")]
            public string department { get; set; }
        }

        [Verb("SyncWTMInsuranceCases", HelpText = "Sync WTM Insurance Cases")]
        class SyncTMInsuranceCasesOptions
        {
            [Option("count", Required = true, HelpText = "Fetch Count,同步筆數")]
            public int count { get; set; }
            //[Option("dayFrom", Required = true, HelpText = "Fetch DayFrom,-1:當天,-2:昨天,類推")]
            //public int dayFrom { get; set; }
        }

        [Verb("GetWTMLoanCases", HelpText = "Import WTM Loan Cases")]
        class GetWTMLoanCasesOptions
        {
            [Option("host", Required = true, HelpText = "SFTP Host")]
            public string host { get; set; }
            [Option("username", Required = true, HelpText = "SFTP User Id")]
            public string username { get; set; }
            [Option("password", Required = true, HelpText = "SFTP Password")]
            public string ppwwdd { get; set; }
            [Option("filepath", Required = true, HelpText = "SFTP File Path")]
            public string filepath { get; set; }
            [Option("prefix", Required = true, HelpText = "File Name Prefix")]
            public string prefix { get; set; }
            [Option("extension", Required = true, HelpText = "File Extension")]
            public string extension { get; set; }
            [Option("datediff", Required = true, HelpText = "Date Difference")]
            public int datediff { get; set; }
            [Option("fieldCount", Required = true, HelpText = "Field Count")]
            public int fieldCount { get; set; }
            [Option("separator", Required = false, HelpText = "Field Separator")]
            public string separator { get; set; }
            [Option("campaign", Required = false, HelpText = "Campaign Code")]
            public string campaign { get; set; }
            [Option("wave", Required = true, HelpText = "Wave Code")]
            public string wave { get; set; }
            [Option("availableMonths", Required = true, HelpText = "Available Months")]
            public int availableMonths { get; set; }
            [Option("department", Required = true, HelpText = "Department Code")]
            public string department { get; set; }
        }

        [Verb("SyncWTMInsuranceCasesNotDial", HelpText = "Sync WTM Insurance Cases")]
        class SyncWTMInsuranceCasesNotDialOptions
        {
            [Option("campaign", Required = true, HelpText = "Campaign Code")]
            public string campaign { get; set; }
        }

        static bool IsSpecialCase(BmsManualReviewFlag manualReviewFlag) =>
            manualReviewFlag != null && (
                manualReviewFlag.p2566 == true ||               // 他行帳戶驗證失敗十次以上
                manualReviewFlag.bornInUSA == true ||           // 需補棄籍證明者
                manualReviewFlag.z22 > 0 ||                     // Z22發查回覆人工審核】
                manualReviewFlag.sameIpWithDiffPid == true ||   // 同一IP不同ID 在7日內開戶
                manualReviewFlag.rarelyWord == true ||          // 客戶資訊內含難字
                !string.IsNullOrWhiteSpace(manualReviewFlag.z21ExceedTimes) // Z21放行原因，"R":限制驗證/"3N":開戶日至今累計超過三次查無記錄
            );

        //GetCaseList --casestatus B --from -10 --to 0 --campaign H0501 --wave WAVE1 --department H0504
        static async Task<int> GetCaseList(GetCaseListOptions opts) {
            var today = DateTime.Now;
            var response = await new GetCaseList().RunAsync(new GetCaseListRq {
                status = opts.casestatus,
                startDate = today.AddMinutes(opts.from).ToString("yyyyMMddHHmmss"),
                endDate = today.AddMinutes(opts.to).ToString("yyyyMMddHHmmss")
            });
            _logger.Info($"GetCaseList->{JsonConvert.SerializeObject(response)}");
            if (response.ResultCode == ResultCodeDef.Success) {
                var amlCampaign = ConfigurationManager.AppSettings["AML.CampaignCode"];
                var specialCampaign = ConfigurationManager.AppSettings["Special.CampaignCode"];
                foreach (var row in response.Result.data) {
                    var importRequest = new CampaignTasksRq
                    {
                        CampaignCode = row.manualReviewFlag?.aml > 0 ? amlCampaign : (IsSpecialCase(row.manualReviewFlag) ? specialCampaign : opts.campaign),
                        WaveCode = opts.wave,
                        DepartmentCode = opts.department,
                        CustId = row.Idno,
                        MobileNo = row.Phone,
                        TaskTag1 = row.SeqNo,
                        JsonData = JsonConvert.SerializeObject(row)
                    };
                    var importResponse = await new ImportBmsCase().RunAsync(importRequest);
                    _logger.Info($"ImportBmsCase->{JsonConvert.SerializeObject(new { Rq = importRequest, Rs = importResponse })}");
                }
            }
            return 0;
        }

        //GetLoanInfo --campaign LOAN01 --wave WAVE1 --department H0504
        static async Task<int> GetLoanInfo(GetLoanInfoOptions opts) {
            var today = DateTime.Today;
            var response = await new GetLoanInfo().RunAsync(new GetLoanInfoRq());
            _logger.Info($"GetLoanInfo->{JsonConvert.SerializeObject(response)}");
            if (response.ResultCode == ResultCodeDef.Success) {
                foreach (var row in response.Result.data) {
                    var importRequest = new CampaignTasksRq
                    {
                        CampaignCode = opts.campaign,
                        WaveCode = opts.wave,
                        DepartmentCode = opts.department,
                        CustId = row.pid,
                        TaskTag1 = row.caseNumber,
                        JsonData = JsonConvert.SerializeObject(row)
                    };
                    var importResponse = await new ImportBmsCase().RunAsync(importRequest);
                    _logger.Info($"ImportBmsCase->{JsonConvert.SerializeObject(new { Rq = importRequest, Rs = importResponse })}");
                }
            }
            return 0;
        }

        static async Task<int> GetAmlCases(GetAmlCasesOptions opts) {
            var filePath = opts.filepath + opts.prefix + DateTime.Today.AddDays(opts.datediff).ToString("yyyyMMdd") + opts.extension;
            _logger.Info($"GetAmlCases->{filePath}");
            var content = ReadFileFromSftp(opts.host, opts.username, opts.ppwwdd, filePath);
            var list = Regex.Replace(content, @"[\r""]", "").Split('\n');
            if (list.Length > 1) {
                foreach (var row in list.Skip(1)) {
                    if (string.IsNullOrWhiteSpace(row)) break;
                    var values = row.Split(opts.separator[0]);
                    var data = JsonConvert.SerializeObject(values);
                    if (values.Length != opts.fieldCount) {
                        _logger.Info($"GetAmlCases->The field count not equals to {opts.fieldCount}, values = {data}");
                        break;
                    }
                    var importRequest = new CampaignTasksRq
                    {
                        CampaignCode = opts.campaign,
                        WaveCode = opts.wave,
                        DepartmentCode = opts.department,
                        CustId = values[0],
                        TaskTag1 = Guid.NewGuid().ToString("N"),
                        JsonData = data
                    };
                    var importResponse = await new ImportBmsCase().RunAsync(importRequest);
                    _logger.Info($"ImportBmsCase->{JsonConvert.SerializeObject(new { Rq = importRequest, Rs = importResponse })}");
                }
            }
            return 0;
        }

        //AML黑名單
        //GetAmlBlackCases --host TsaiHomeCloud.synology.me  --username Devpro  --password ab1234.. --filepath /oli_ftc/download/aml/ --prefix insurance_  --extension .txt --datediff 0 --fieldCount 24 --wave test --department test
        static async Task<int> GetAmlBlackCases(GetAmlBlackCasesOptions opts)
        {
            var filePath = opts.filepath + opts.prefix + DateTime.Today.AddDays(opts.datediff).ToString("yyyyMMdd") + opts.extension;
            _logger.Info($"GetAmlBlackCases->{filePath}");
            var content = ReadFileFromSftp(opts.host, opts.username, opts.ppwwdd, filePath);
            var list = Regex.Replace(content, @"[\r""]", "").Split('\n');
            if (list.Length > 1)
            {
                foreach (var row in list)
                {
                    if (string.IsNullOrWhiteSpace(row)) break;
                    var values = row.Split('\t');
                    var data = JsonConvert.SerializeObject(values);
                    if (values.Length != opts.fieldCount)
                    {
                        _logger.Info($"GetAmlBlackCases->The field count not equals to {opts.fieldCount}, values = {data}");
                        break;
                    }
                    var importRequest = new CampaignTasksRq
                    {
                        CampaignCode = values[1],
                        WaveCode = opts.wave,
                        DepartmentCode = opts.department,
                        ChineseName = values[5],
                        CustId = values[7],
                        MobileNo = values[9],
                        TaskTag1 = values[15],
                        JsonData = data
                    };
                    var query = await new SelectAMLCaseExist().SelectAMLCaseExistAsync(importRequest);
                    if (query.AffectedRowCount > 0)
                    {
                        _logger.Info($"ImportBmsBlackCase->The Case Already Exist in campaign:{importRequest.CampaignCode}, Order No:{importRequest.TaskTag1}");
                        continue;
                    }
                    var importResponse = await new ImportBmsCase().RunAsync(importRequest);
                    _logger.Info($"ImportBmsBlackCase->{JsonConvert.SerializeObject(new { Rq = importRequest, Rs = importResponse })}");
                }
            }
            return 0;
        }

        //應電訪名單
        //GetWTMInsuranceCases --host TsaiHomeCloud.synology.me  --username Devpro  --password ab1234.. --filepath /oli_ftc/download/wtm/ --prefix wtm_  --extension .txt --datediff 0 --fieldCount 41 --wave test --department test
        static async Task<int> GetWTMInsuranceCases(GetWTMInsuranceCasesOptions opts)
        {
            var filePath = opts.filepath + opts.prefix + DateTime.Today.AddDays(opts.datediff).ToString("yyyyMMdd") + opts.extension;
            _logger.Info($"GetWTMInsuranceCases->{filePath}");
            var content = ReadFileFromSftp(opts.host, opts.username, opts.ppwwdd, filePath);
            var list = Regex.Replace(content, @"[\r""]", "").Split('\n');
            if (list.Length > 1)
            {
                foreach (var row in list)
                {
                    if (string.IsNullOrWhiteSpace(row)) break;
                    var values = row.Split('\t');
                    var data = JsonConvert.SerializeObject(values);
                    if (values.Length != opts.fieldCount)
                    {
                        _logger.Info($"GetWTMInsuranceCases->The field count not equals to {opts.fieldCount}, values = {data}");
                        break;
                    }
                    var importRequest = new CampaignTasksRq
                    {
                        CampaignCode = values[2],
                        WaveCode = opts.wave,
                        DepartmentCode = opts.department,
                        Int01 = (string.IsNullOrEmpty(values[0])) ? 0 : Convert.ToInt32(values[0]),
                        Data25 = values[1],
                        Data26 = values[3],
                        Data08 = values[4],
                        Data07 = values[5],
                        Data09 = values[6],
                        Data10 = values[7],
                        Data11 = (string.IsNullOrEmpty(values[8])) ? string.Empty : Convert.ToDateTime(values[8]).ToString("yyyy/MM/dd"),
                        Data12 = (string.IsNullOrEmpty(values[9])) ? string.Empty : Convert.ToDateTime(values[9]).ToString("yyyy/MM/dd"),
                        Data13 = values[10],
                        Int02 = (string.IsNullOrEmpty(values[11])) ? 0 : Convert.ToInt32(values[11]),
                        Data14 = values[12],
                        Int03 = (string.IsNullOrEmpty(values[13])) ? 0 : (int)Convert.ToDouble(values[13]),
                        ChineseName = values[14],
                        Data01 = values[15],
                        CustId = values[16],
                        Gender = Convert.ToInt16(values[17]),
                        DOB = (string.IsNullOrEmpty(values[18])) ? (DateTime?)null : Convert.ToDateTime(values[18]),
                        MobileNo = values[19],
                        CorrespondenceTelNo = values[20],
                        Email1 = values[21],
                        CorrespondenceAddress = values[22],
                        Data24 = values[23],
                        Data15 = values[24],
                        Data16 = values[25],
                        Data17 = values[26],
                        Data06 = values[27],
                        Data18 = values[28],
                        Data19 = values[29],
                        Int04 = (string.IsNullOrEmpty(values[30])) ? 0 : Convert.ToInt32(values[30]),
                        Data20 = values[31],
                        Int05 = (string.IsNullOrEmpty(values[32])) ? 0 : Convert.ToInt32(values[32]),
                        Data21 = values[33],
                        Data22 = values[34],
                        Data23 = values[35],
                        Data02 = values[36],
                        Data03 = values[37],
                        Data04 = values[38],
                        Data05 = values[39],
                        CreatedAt = DateTime.Now,
                        TaskTag1 = values[1],
                        JsonData = data,
                        Int18 = (string.IsNullOrEmpty(values[18])) ? 0 : Convert.ToInt16(Convert.ToDateTime(values[18]).Year),
                        Int19 = (string.IsNullOrEmpty(values[18])) ? 0 : Convert.ToInt16(Convert.ToDateTime(values[18]).Month),
                        Int20 = (string.IsNullOrEmpty(values[18])) ? 0 : Convert.ToInt16(Convert.ToDateTime(values[18]).Day),
                        Data30 = values[40]//電訪截止日期
                    };
                    var importResponse = await new ImportCampaignTasks().ImportCampaignTasksAsync(importRequest);
                    _logger.Info($"GetWTMInsuranceCases->{JsonConvert.SerializeObject(new { Rq = importRequest, Rs = importResponse })}");
                }
            }
            return 0;
        }

        //信貸電訪名單
        //GetWTMLoanCases --host TsaiHomeCloud.synology.me  --username Devpro  --password ab1234.. --filepath /oli_ftc/download/wtm/ --prefix wtm_  --extension .csv --datediff 0 --fieldCount 28 --campaign test --wave test --availableMonths 1 --department test
        static async Task<int> GetWTMLoanCases(GetWTMLoanCasesOptions opts)
        {
            var filePath = opts.filepath + opts.prefix + DateTime.Today.AddDays(opts.datediff).ToString("yyyyMMdd") + opts.extension;
            _logger.Info($"GetWTMLoanCases->{filePath}");
            var waveCode = opts.wave + $"_{DateTime.Today.AddDays(opts.datediff).ToString("yyyyMMdd")}";
            var content = ReadFileFromSftp(opts.host, opts.username, opts.ppwwdd, filePath);
            var rowCount = 0;
            var list = Regex.Replace(content, @"[\r]", "").Split('\n');
            if (list.Length > 1)
            {
                var createWaveResponse = await new ImportCampaignTasks().CreateWaveAsync(opts.campaign, waveCode, opts.availableMonths);

                foreach (var row in list)
                {
                    rowCount++;
                    if (rowCount == 1) continue;//跳過標題列
                    if (string.IsNullOrWhiteSpace(row)) break;
                    var values = row.Split(',');
                    var data = JsonConvert.SerializeObject(values);
                    if (values.Length != opts.fieldCount)
                    {
                        _logger.Info($"GetWTMLoanCases->The field count not equals to {opts.fieldCount}, values = {data}");
                        break;
                    }
                    var importRequest = new CampaignTasksRq
                    {
                        CampaignCode = opts.campaign,
                        WaveCode = waveCode,
                        CustId = values[0],
                        ChineseName = values[1],
                        DOB = (string.IsNullOrEmpty(values[2])) ? (DateTime?)null : Convert.ToDateTime(values[2]),
                        MobileNo = values[3],
                        CorrespondenceTelNo = values[4],
                        CorrespondenceExt = values[5],
                        PermanentTelNo = values[6],
                        PermanentExt = values[7],
                        ResidentialTelNo = values[8],
                        ResidentialExt = values[9],
                        CompanyTelNo = values[10],
                        CompanyExt = values[11],
                        Email1 = values[12],
                        Email2 = values[13],
                        FaxNo = values[14],
                        CorrespondenceZip = values[15],
                        CorrespondenceAddress = values[16],
                        PermanentZip = values[17],
                        PermanentAddress = values[18],
                        ResidentialZip = values[19],
                        ResidentialAddress = values[20],
                        CompanyZip = values[21],
                        CompanyAddress = values[22],
                        TaskTag1 = values[23],
                        Note = values[24],
                        OtherTelNo1 = values[25],
                        OtherTelNo2 = values[26],
                        OtherTelNo3 = values[27],
                        DepartmentCode = opts.department,
                        CreatedAt = DateTime.Now,
                    };
                    var importResponse = await new ImportCampaignTasks().ImportCampaignTasksAsync(importRequest);
                    _logger.Info($"GetWTMLoanCases->{JsonConvert.SerializeObject(new { Rq = importRequest, Rs = importResponse })}");
                }
            }
            return 0;
        }

        //同步應電訪名單
        //SyncWTMInsuranceCases --count 100
        static async Task<int> SyncWTMInsuranceCases(SyncTMInsuranceCasesOptions opts)
        {
            var query = await new SyncCampaignTasks().SyncCampaignTasksAsync(opts.count);
            return 0;
        }

        //同步未撥打電訪名單
        //SyncWTMInsuranceCasesNotDial --campaign Q0001,Q0002
        static async Task<int> SyncWTMInsuranceCasesNotDial(SyncWTMInsuranceCasesNotDialOptions opts)
        {
            return await new SyncCampaignTasks().SyncCampaignTasksNotDialAsync(opts.campaign);
        }

        static string ReadFileFromSftp(string host, string userId, string password, string filePath) {
            using (var sftp = new SftpClient(host, userId, password)) {
                sftp.Connect();
                if (!sftp.Exists(filePath)) {
                    _logger.Info($"ReadFileFromFtp->File {filePath} does not exist");
                    return string.Empty;
                }
                using (var stream = new MemoryStream()) {
                    sftp.DownloadFile(filePath, stream);
                    stream.Seek(0, SeekOrigin.Begin);
                    using (var reader = new StreamReader(stream)) {
                        var data = reader.ReadToEnd();
                        _logger.Info($"ReadFileFromFtp->Download {filePath} completed");
                        return data;
                    }
                }
            }
        }
    }
}
