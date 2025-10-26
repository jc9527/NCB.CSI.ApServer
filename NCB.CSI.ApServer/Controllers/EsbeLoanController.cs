using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.eLoan;
using NCB.CSI.Models.ESB.eLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/eLoan")]
    [JwtValidation(TokenLevel.None)]
    public class EsbeLoanController : BaseController
    {
        /// <summary>
        ///  案件狀態查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanAppStatInq")]
        public Task<Response<LoanAppStatInqRs>> LoanAppStatInq(Request<LoanAppStatInqRq> request) => SvcRepo.Resolve<LoanAppStatInq>().RunAsync(request);
        /// <summary>
        ///  申請報價查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanSalesQuoteInq")]
        public Task<Response<LoanSalesQuoteInqRs>> LoanSalesQuoteInq(Request<LoanSalesQuoteInqRq> request) => SvcRepo.Resolve<LoanSalesQuoteInq>().RunAsync(request);
        /// <summary>
        ///  變更報價查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanSalesQuoteAppealInq")]
        public Task<Response<LoanSalesQuoteAppealInqRs>> LoanSalesQuoteAppealInq(Request<LoanSalesQuoteAppealInqRq> request) => SvcRepo.Resolve<LoanSalesQuoteAppealInq>().RunAsync(request);
        /// <summary>
        ///  檢視契據
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PrectrctInq")]
        public Task<Response<PrectrctInqRs>> PrectrctInq(Request<PrectrctInqRq> request) => SvcRepo.Resolve<PrectrctInq>().RunAsync(request);
        /// <summary>
        ///  取得續約資料查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanRenewInfoInq")]
        public Task<Response<LoanRenewInfoInqRs>> LoanRenewInfoInq(Request<LoanRenewInfoInqRq> request) => SvcRepo.Resolve<LoanRenewInfoInq>().RunAsync(request);
        /// <summary>
        ///  回覆續約或不續約
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanRenewStatMod")]
        public Task<Response<LoanRenewStatModRs>> LoanRenewStatMod(Request<LoanRenewStatModRq> request) => SvcRepo.Resolve<LoanRenewStatMod>().RunAsync(request);
        /// <summary>
        ///  撥款資訊
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DsbrInfoAdd")]
        public Task<Response<DsbrInfoAddRs>> DsbrInfoAdd(Request<DsbrInfoAddRq> request) => SvcRepo.Resolve<DsbrInfoAdd>().RunAsync(request);
        /// <summary>
        ///  查詢補件內容
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AttchDocListInq")]
        public Task<Response<AttchDocListInqRs>> AttchDocListInq(Request<AttchDocListInqRq> request) => SvcRepo.Resolve<AttchDocListInq>().RunAsync(request);
        /// <summary>
        ///  取得傳送補件連結
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AttchDocLnkInq")]
        public Task<Response<AttchDocLnkInqRs>> AttchDocLnkInq(Request<AttchDocLnkInqRq> request) => SvcRepo.Resolve<AttchDocLnkInq>().RunAsync(request);
        /// <summary>
        ///  同意契約內容
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LoanCtrctAdd")]
        public Task<Response<LoanCtrctAddRs>> LoanCtrctAdd(Request<LoanCtrctAddRq> request) => SvcRepo.Resolve<LoanCtrctAdd>().RunAsync(request);
    }
}