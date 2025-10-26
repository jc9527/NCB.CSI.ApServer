using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.UpgradeAccount;
using NCB.CSI.Models.BMS.UpgradeAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/UpgradeAccount")]
    [JwtValidation(TokenLevel.None)]
    public class BmsUpgradeAccountController : BaseController {
        /// <summary>
        /// 客服呼叫數位帳戶升級(客服視訊帳戶升級完成)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("IVRCheckUpgradeAccount")]
        public Task<Response<IVRCheckUpgradeAccountRs>> IVRCheckUpgradeAccount(Request<IVRCheckUpgradeAccountRq> request) => SvcRepo.Resolve<IVRCheckUpgradeAccount>().RunAsync(request);

        /// <summary>
        /// 查詢自然人憑證驗證結果
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetEddaCheckResult")]
        public Task<Response<GetEddaCheckResultRs>> GetEddaCheckResult(Request<GetEddaCheckResultRq> request) => SvcRepo.Resolve<GetEddaCheckResult>().RunAsync(request);
    }
}