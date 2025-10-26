using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.Member;
using NCB.CSI.Models.BMS.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/Member")]
    [JwtValidation(TokenLevel.None)]
    public class BmsMemberController : BaseController {
        /// <summary>
        /// 查詢會員資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetMemberInfo")]
        public Task<Response<GetMemberInfoRs>> GetMemberInfo(Request<GetMemberInfoRq> request) => SvcRepo.Resolve<GetMemberInfo>().RunAsync(request);

        /// <summary>
        /// 修改會員資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateMemberInfo")]
        public Task<Response<UpdateMemberInfoRs>> UpdateMemberInfo(Request<UpdateMemberInfoRq> request) => SvcRepo.Resolve<UpdateMemberInfo>().RunAsync(request);

        /// <summary>
        /// 客服-查詢會員數位等級的驗證狀態和升級時間
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetAccountUpgrade")]
        public Task<Response<GetAccountUpgradeRs>> GetAccountUpgrade(Request<GetAccountUpgradeRq> request) => SvcRepo.Resolve<GetAccountUpgrade>().RunAsync(request);

        /// <summary>
        /// 客服-升級數3A+
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TransferQuotaUpgrade")]
        public Task<Response<TransferQuotaUpgradeRs>> TransferQuotaUpgrade(Request<TransferQuotaUpgradeRq> request) => SvcRepo.Resolve<TransferQuotaUpgrade>().RunAsync(request);
    }
}