using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.CurrentAccount;
using NCB.CSI.Models.ESB.CurrentAccount;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/CurrentAccount")]
    [JwtValidation(TokenLevel.None)]
    public class EsbCurrentAccountController : BaseController {
        /// <summary>
        /// 帳號明細查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcctDtlInq")]
        public Task<Response<AcctDtlInqRs>> AcctDtlInq(Request<AcctDtlInqRq> request) => SvcRepo.Resolve<AcctDtlInq>().RunAsync(request);
        /// <summary>
        /// 加息券利率條件調整
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CampIntrstRateMod")]
        public Task<Response<CampIntrstRateModRs>> CampIntrstRateMod(Request<CampIntrstRateModRq> request) => SvcRepo.Resolve<CampIntrstRateMod>().RunAsync(request);
        /// <summary>
        /// 優惠利率到期(取消)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CampIntrstRateCan")]
        public Task<Response<CampIntrstRateCanRs>> CampIntrstRateCan(Request<CampIntrstRateCanRq> request) => SvcRepo.Resolve<CampIntrstRateCan>().RunAsync(request);

    }
}
