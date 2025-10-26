using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Base;
using NCB.CSI.ApServer.Services.ESB.PaymentOrder;
using NCB.CSI.Models.ESB.PaymentOrder;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Token;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/PaymentOrder")]
    [JwtValidation(TokenLevel.None)]
    public class EsbPaymentOrderController : BaseController {
        /// <summary>
        /// 自跨行帳務交易紀錄-查詢摘要
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FiscTxnLogSummInq")]
        public Task<Response<FiscTxnLogSummInqRs>> FiscTxnLogSummInq(Request<FiscTxnLogSummInqRq> request) => SvcRepo.Resolve<FiscTxnLogSummInq>().RunAsync(request);
        /// <summary>
        /// 自動化自跨行帳務交易-明細查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FiscTxnLogDtlsInq")]
        public Task<Response<FiscTxnLogDtlsInqRs>> FiscTxnLogDtlsInq(Request<FiscTxnLogDtlsInqRq> request) => SvcRepo.Resolve<FiscTxnLogDtlsInq>().RunAsync(request);
        /// <summary>
        ///  xx註解xx
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TWDFundXferAdd")]
        public Task<Response<TWDFundXferAddRs>> TWDFundXferAdd(Request<TWDFundXferAddRq> request) => SvcRepo.Resolve<TWDFundXferAdd>().RunAsync(request);
        /// <summary>
        ///  開戶交易與跨行交易
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PmtAdd")]
        public Task<Response<PmtAddRs>> PmtAdd(Request<PmtAddRq> request) => SvcRepo.Resolve<PmtAdd>().RunAsync(request);
        /// <summary>
        ///  FXML交易紀錄查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PmtInq")]
        public Task<Response<PmtInqRs>> PmtInq(Request<PmtInqRq> request) => SvcRepo.Resolve<PmtInq>().RunAsync(request);
        /// <summary>
        ///  轉帳交易
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FundXferAdd")]
        public Task<Response<FundXferAddRs>> FundXferAdd(Request<FundXferAddRq> request) => SvcRepo.Resolve<FundXferAdd>().RunAsync(request);
    }
}