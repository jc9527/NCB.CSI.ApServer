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
using NCB.CSI.ApServer.Services.MIP;
using NCB.CSI.Models.MIP;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("MIP")]
    [JwtValidation(TokenLevel.None)]
    public class MipController : BaseController {
        [HttpPost]
        [Route("MsgSend")]
        public Task<Response<MsgSendRs>> MsgSend(Request<MsgSendRq> request) => SvcRepo.Resolve<MsgSend>().RunAsync(request);
        [HttpPost]
        [Route("QueryResult")]
        public Task<Response<QueryResultRs>> QueryResult(Request<QueryResultRq> request) => SvcRepo.Resolve<QueryResult>().RunAsync(request);
        [HttpPost]
        [Route("Resend")]
        public Task<Response<ResendRs>> Resend(Request<ResendRq> request) => SvcRepo.Resolve<Resend>().RunAsync(request);
    }
}
