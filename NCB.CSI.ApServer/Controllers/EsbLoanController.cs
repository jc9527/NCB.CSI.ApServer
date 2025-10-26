using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.Loan;
using NCB.CSI.Models.ESB.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/Loan")]
    [JwtValidation(TokenLevel.None)]
    public class EsbLoanController : BaseController {
        /// <summary>
        ///  提貸款提前解約模擬試算及結果查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanEarlyTermSim")]
        public Task<Response<LoanEarlyTermSimRs>> PmtScheInq(Request<LoanEarlyTermSimRq> request) => SvcRepo.Resolve<LoanEarlyTermSim>().RunAsync(request);
        /// <summary>
        ///  還款時程表查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PmtScheInq")]
        public Task<Response<PmtScheInqRs>> PmtScheInq(Request<PmtScheInqRq> request) => SvcRepo.Resolve<PmtScheInq>().RunAsync(request);
        /// <summary>
        ///  逾期未繳款查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("OvrdListInq")]
        public Task<Response<OvrdListInqRs>> OvrdListInq(Request<OvrdListInqRq> request) => SvcRepo.Resolve<OvrdListInq>().RunAsync(request);
        /// <summary>
        ///  放款狀態查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanStatInq")]
        public Task<Response<LoanStatInqRs>> LoanStatInq(Request<LoanStatInqRq> request) => SvcRepo.Resolve<LoanStatInq>().RunAsync(request);
        /// <summary>
        ///  JCIC Z21及Z22查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("eJCICActInq")]
        public Task<Response<eJCICActInqRs>> eJCICActInq(Request<eJCICActInqRq> request) => SvcRepo.Resolve<eJCICActInq>().RunAsync(request);
    }
}