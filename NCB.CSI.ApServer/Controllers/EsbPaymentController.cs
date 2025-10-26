using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.Payment;
using NCB.CSI.Models.ESB.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/Payment")]
    [JwtValidation(TokenLevel.None)]
    public class EsbPaymentController : BaseController {
        /// <summary>
        ///  圈存及解圈
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("LockAdd")]
        public Task<Response<LockAddRs>> LockAdd(Request<LockAddRq> request) => SvcRepo.Resolve<LockAdd>().RunAsync(request);
        /// <summary>
        ///  卡片線上解圈查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UnlockInq")]
        public Task<Response<UnlockInqRs>> UnlockInq(Request<UnlockInqRq> request) => SvcRepo.Resolve<UnlockInq>().RunAsync(request);
        /// <summary>
        ///  卡片線上解圈
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UnlockAdd")]
        public Task<Response<UnlockAddRs>> UnlockAdd(Request<UnlockAddRq> request) => SvcRepo.Resolve<UnlockAdd>().RunAsync(request);
    }
}