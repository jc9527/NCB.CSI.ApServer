using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.SelfChannel;
using NCB.CSI.Models.ESB.SelfChannel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/SelfChannel")]
    [JwtValidation(TokenLevel.None)]
    public class EsbSelfChannelController : BaseController {
        /// <summary>
        /// 自動化當日可用餘額
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SelfChanAcctBalDtlsInq")]
        public Task<Response<SelfChanAcctBalDtlsInqRs>> SelfChanAcctBalDtlsInq(Request<SelfChanAcctBalDtlsInqRq> request) => SvcRepo.Resolve<SelfChanAcctBalDtlsInq>().RunAsync(request);
    }
}