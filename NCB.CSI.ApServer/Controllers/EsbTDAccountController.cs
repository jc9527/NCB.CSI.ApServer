using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Base;
using NCB.CSI.ApServer.Services.ESB.TDAccount;
using NCB.CSI.Models.ESB.TDAccount;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.Token;
using Devpro.Shared.ActionFilters;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/TDAccount")]
    [JwtValidation(TokenLevel.None)]
    public class EsbTDAccountController : BaseController {
        /// <summary>
        /// 定存主檔查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDAcctDtlInq")]
        public Task<Response<TDAcctDtlInqRs>> TDAcctDtlInq(Request<TDAcctDtlInqRq> request) => SvcRepo.Resolve<TDAcctDtlInq>().RunAsync(request);
        /// <summary>
        /// 定存歷史查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDAcctDtlHisInq")]
        public Task<Response<TDAcctDtlHisInqRs>> TDAcctDtlHisInq(Request<TDAcctDtlHisInqRq> request) => SvcRepo.Resolve<TDAcctDtlHisInq>().RunAsync(request);
        /// <summary>
        ///  定存中途解約作業
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDCtrctCan")]
        public Task<Response<TDCtrctCanRs>> TDCtrctCan(Request<TDCtrctCanRq> request) => SvcRepo.Resolve<TDCtrctCan>().RunAsync(request);
        /// <summary>
        ///  定存續存條件變更
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDCtrctContMod")]
        public Task<Response<TDCtrctContModRs>> TDCtrctContMod(Request<TDCtrctContModRq> request) => SvcRepo.Resolve<TDCtrctContMod>().RunAsync(request);
        /// <summary>
        ///  開定存單前模擬
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDCal")]
        public Task<Response<TDCalRs>> TDCal(Request<TDCalRq> request) => SvcRepo.Resolve<TDCal>().RunAsync(request);
        /// <summary>
        ///  開單前模擬查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDCalInq")]
        public Task<Response<TDCalInqRs>> TDCalInq(Request<TDCalInqRq> request) => SvcRepo.Resolve<TDCalInq>().RunAsync(request);
        /// <summary>
        ///  查詢中途解約後可領金額
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDPreClsCal")]
        public Task<Response<TDPreClsCalRs>> TDPreClsCal(Request<TDPreClsCalRq> request) => SvcRepo.Resolve<TDPreClsCal>().RunAsync(request);
        /// <summary>
        ///  開單前模擬及查詢合併
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDAcctOpnCalInq")]
        public Task<Response<TDAcctOpnCalInqRs>> TDAcctOpnCalInq(Request<TDAcctOpnCalInqRq> request) => SvcRepo.Resolve<TDAcctOpnCalInq>().RunAsync(request);
        /// <summary>
        ///  定存中途解約作業
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TDTermCalCan")]
        public Task<Response<TDTermCalCanRs>> TDTermCalCan(Request<TDTermCalCanRq> request) => SvcRepo.Resolve<TDTermCalCan>().RunAsync(request);
    }
}