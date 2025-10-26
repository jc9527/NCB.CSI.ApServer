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
using NCB.CSI.ApServer.Services.OTP;
using NCB.CSI.Models.OTP;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("OTP")]
    [JwtValidation(TokenLevel.None)]
    public class OtpController : BaseController {
        [HttpPost]
        [Route("svDeRegister")]
        public Task<Response<svDeRegisterRs>> svDeRegister(Request<svDeRegisterRq> request) => SvcRepo.Resolve<svDeRegister>().RunAsync(request);
        [HttpPost]
        [Route("svSend_SMS")]
        public Task<Response<svSend_SMSRs>> svSend_SMS(Request<svSend_SMSRq> request) => SvcRepo.Resolve<svSend_SMS>().RunAsync(request);
        [HttpPost]
        [Route("svVerify_SMS")]
        public Task<Response<svVerify_SMSRs>> svVerify_SMS(Request<svVerify_SMSRq> request) => SvcRepo.Resolve<svVerify_SMS>().RunAsync(request);
        [HttpPost]
        [Route("svGet_Device_Status")]
        public Task<Response<svGet_Device_StatusRs>> svGet_Device_Status(Request<svGet_Device_StatusRq> request) => SvcRepo.Resolve<svGet_Device_Status>().RunAsync(request);
    }
}
