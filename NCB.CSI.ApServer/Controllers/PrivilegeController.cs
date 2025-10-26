using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Base;
using NCB.CSI.ApServer.Services.BMS.CreateAccount;
using NCB.CSI.ApServer.Services.BMS.Loan;
using NCB.CSI.ApServer.Services.CSI;
using NCB.CSI.ApServer.Services.ESB.Customer;
using NCB.CSI.Models.BMS.CreateAccount;
using NCB.CSI.Models.BMS.Loan;
using NCB.CSI.Models.CSI;
using NCB.CSI.Models.ESB.Customer;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("Privilege")]
    public class PrivilegeController : BaseController {
        /// <summary>
        /// Email(手機)查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ESB/Customer/CustIdntInq")]
        public Task<Response<CustIdntInqRs>> CustIdntInq(Request<CustIdntInqRq> request) => SvcRepo.Resolve<CustIdntInq>().RunAsync(request);

        /// <summary>
        /// 下審核結果_查客戶的狀態
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BMS/CreateAccount/GetCaseList")]
        public Task<Response<GetCaseListRs>> GetCaseList(Request<GetCaseListRq> request) => SvcRepo.Resolve<GetCaseList>().RunAsync(request);

        /// <summary>
        /// 下審核結果_查詢貸款進件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BMS/Loan/GetLoanInfo")]
        public Task<Response<GetLoanInfoRs>> GetLoanInfo(Request<GetLoanInfoRq> request) => SvcRepo.Resolve<GetLoanInfo>().RunAsync(request);

        /// <summary>
        /// 匯入需要作服後續作業的開戶申請件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CSI/ImportBmsCase")]
        public Task<Response<CampaignTasksRs>> ImportBmsCase(Request<CampaignTasksRq> request) => SvcRepo.Resolve<ImportBmsCase>().RunAsync(request);
    }
}
