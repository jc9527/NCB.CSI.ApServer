using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.Common;
using NCB.CSI.Models.BMS.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/Common")]
    [JwtValidation(TokenLevel.None)]
    public class BmsCommonController : BaseController {
        /// <summary>
        /// 全國銀行列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Bank")]
        public Task<Response<BankRs>> Bank(Request<BankRq> request) => SvcRepo.Resolve<Bank>().RunAsync(request);
        /// <summary>
        /// 作服 - 撈取行內黑名單API
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetBlackList")]
        public Task<Response<GetBlackListRs>> GetBlackList(Request<GetBlackListRq> request) => SvcRepo.Resolve<GetBlackList>().RunAsync(request);
        /// <summary>
        /// 作服 - 新增行內黑名單API
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CreateBlackList")]
        public Task<Response<CreateBlackListRs>> CreateBlackList(Request<CreateBlackListRq> request) => SvcRepo.Resolve<CreateBlackList>().RunAsync(request);
        /// <summary>
        /// 作服 - 修改行內黑名單API
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ModifyBlackList")]
        public Task<Response<ModifyBlackListRs>> ModifyBlackList(Request<ModifyBlackListRq> request) => SvcRepo.Resolve<ModifyBlackList>().RunAsync(request);
        /// <summary>
        /// 作服 - 修改個人資訊(姓名、戶籍地址)
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdatePersonalInfo")]
        public Task<Response<UpdatePersonalInfoRs>> UpdatePersonalInfo(Request<UpdatePersonalInfoRq> request) => SvcRepo.Resolve<UpdatePersonalInfo>().RunAsync(request);
        /// <summary>
        /// 作管 - 取得行職業清單
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetCodeBooks")]
        public Task<Response<GetCodeBooksRs>> GetCodeBooks(Request<GetCodeBooksRq> request) => SvcRepo.Resolve<GetCodeBooks>().RunAsync(request);
        /// <summary>
        /// 作服 - 取得EDD問卷資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetEDDSurvey")]
        public Task<Response<GetEDDSurveyRs>> GetEDDSurvey(Request<GetEDDSurveyRq> request) => SvcRepo.Resolve<GetEDDSurvey>().RunAsync(request);
    }
}