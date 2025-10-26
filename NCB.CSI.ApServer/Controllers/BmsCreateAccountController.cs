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
using NCB.CSI.ApServer.Services.BMS.CreateAccount;
using NCB.CSI.Models.BMS.CreateAccount;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/CreateAccount")]
    [JwtValidation(TokenLevel.None)]
    public class BmsCreateAccountController : BaseController {
        /// <summary>
        /// 客服-查詢開戶進件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetCreateInfo")]
        public Task<Response<GetCreateInfoRs>> GetCreateInfo(Request<GetCreateInfoRq> request) => SvcRepo.Resolve<GetCreateInfo>().RunAsync(request);
        /// <summary>
        /// 下審核結果_查客戶的狀態
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetCaseList")]
        public Task<Response<GetCaseListRs>> GetCaseList(Request<GetCaseListRq> request) => SvcRepo.Resolve<GetCaseList>().RunAsync(request);

        /// <summary>
        /// 下審核結果_下審核結果
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateStatus")]
        public Task<Response<UpdateStatusRs>> UpdateStatus(Request<UpdateStatusRq> request) => SvcRepo.Resolve<UpdateStatus>().RunAsync(request);

        /// <summary>
        /// 作服 - 修改行職業
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ModifyIndustryAndJob")]
        public Task<Response<ModifyIndustryAndJobRs>> UpdateStatus(Request<ModifyIndustryAndJobRq> request) => SvcRepo.Resolve<ModifyIndustryAndJob>().RunAsync(request);
    }
}
