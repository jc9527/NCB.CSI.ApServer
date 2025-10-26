using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.Rate;
using NCB.CSI.Models.BMS.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/Rate")]
    [JwtValidation(TokenLevel.None)]
    public class BmsRateController : BaseController {
        /// <summary>
        /// 查詢牌告利率
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetRates")]
        public Task<Response<GetRatesRs>> GetRates(Request<GetRatesRq> request) => SvcRepo.Resolve<GetRates>().RunAsync(request);

        /// <summary>
        /// 新增牌告利率
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddRate")]
        public Task<Response<AddRateRs>> AddRate(Request<AddRateRq> request) => SvcRepo.Resolve<AddRate>().RunAsync(request);
    }
}