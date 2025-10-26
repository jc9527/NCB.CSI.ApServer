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
using NCB.CSI.ApServer.Services.CBS;
using NCB.CSI.Models.CBS;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("CBS")]
    [JwtValidation(TokenLevel.None)]
    public class CbsController : BaseController {
        [HttpPost]
        [Route("NCBAPI17007")]
        public Task<Response<NCBAPI17007Rs>> NCBAPI17007(Request<NCBAPI17007Rq> request) => SvcRepo.Resolve<NCBAPI17007>().RunAsync(request);
    }
}
