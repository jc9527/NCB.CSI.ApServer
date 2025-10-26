using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Base;
using NCB.CSI.ApServer.Services.ESB.RewardPoints;
using NCB.CSI.Models.ESB.RewardPoints;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Token;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/RewardPoints")]
    [JwtValidation(TokenLevel.None)]
    public class EsbRewardPointsController : BaseController {
        /// <summary>
        ///  點數餘額查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RwdPntsInq")]
        public Task<Response<RwdPntsInqRs>> RwdPntsInq(Request<RwdPntsInqRq> request) => SvcRepo.Resolve<RwdPntsInq>().RunAsync(request);
        /// <summary>
        ///  查詢客戶點數歷程 (照交易時間遞減排序)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RwdPntsHistInq")]
        public Task<Response<RwdPntsHistInqRs>> RwdPntsHistInq(Request<RwdPntsHistInqRq> request) => SvcRepo.Resolve<RwdPntsHistInq>().RunAsync(request);
        /// <summary>
        ///  查詢客戶即將到期點數
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RwdPntsExpInq")]
        public Task<Response<RwdPntsExpInqRs>> RwdPntsExpInq(Request<RwdPntsExpInqRq> request) => SvcRepo.Resolve<RwdPntsExpInq>().RunAsync(request);
        /// <summary>
        ///  查詢客戶黑名單狀態
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RwdPntsCustStatInq")]
        public Task<Response<RwdPntsCustStatInqRs>> RwdPntsCustStatInq(Request<RwdPntsCustStatInqRq> request) => SvcRepo.Resolve<RwdPntsCustStatInq>().RunAsync(request);
        /// <summary>
        ///  查詢第三方總點數
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("VndrRwdPntsInq")]
        public Task<Response<VndrRwdPntsInqRs>> VndrRwdPntsInq(Request<VndrRwdPntsInqRq> request) => SvcRepo.Resolve<VndrRwdPntsInq>().RunAsync(request);
        /// <summary>
        ///  活動管理-列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PointCampInq")]
        public Task<Response<PointCampInqRs>> PointCampInq(Request<PointCampInqRq> request) => SvcRepo.Resolve<PointCampInq>().RunAsync(request);
        /// <summary>
        ///  供應商管理-列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PointVndrInq")]
        public Task<Response<PointVndrInqRs>> PointVndrInq(Request<PointVndrInqRq> request) => SvcRepo.Resolve<PointVndrInq>().RunAsync(request);
        /// <summary>
        ///  活動類別管理-列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PointCampGrpInq")]
        public Task<Response<PointCampGrpInqRs>> PointCampGrpInq(Request<PointCampGrpInqRq> request) => SvcRepo.Resolve<PointCampGrpInq>().RunAsync(request);
        /// <summary>
        ///  加(含取消)客戶點數
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RwdPntsAwardsAdd")]
        public Task<Response<RwdPntsAwardsAddRs>> RwdPntsAwardsAdd(Request<RwdPntsAwardsAddRq> request) => SvcRepo.Resolve<RwdPntsAwardsAdd>().RunAsync(request);
    }
}