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
using NCB.CSI.ApServer.Services.CM;
using NCB.CSI.Models.CM;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("CM")]
    [JwtValidation(TokenLevel.None)]
    public class CmController : BaseController {
        [HttpPost]
        [Route("CallViewer")]
        public Task<Response<CallViewerRs>> CallViewer(Request<CallViewerRq> request) => SvcRepo.Resolve<CallViewer>().RunAsync(request);

        [HttpPost]
        [Route("GetFile")]
        public Task<Response<GetFileRs>> GetFile(Request<GetFileRq> request) => SvcRepo.Resolve<GetFile>().RunAsync(request);

        [HttpPost]
        [Route("UploadFile")]
        public Task<Response<UploadFileRs>> UploadFile(Request<UploadFileRq> request) => SvcRepo.Resolve<UploadFile>().RunAsync(request);

        [HttpPost]
        [Route("DeleteFile")]
        public Task<Response<DeleteFileRs>> DeleteFile(Request<DeleteFileRq> request) => SvcRepo.Resolve<DeleteFile>().RunAsync(request);
    }
}
