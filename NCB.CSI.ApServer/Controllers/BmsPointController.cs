using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.Point;
using NCB.CSI.Models.BMS.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/Point")]
    [JwtValidation(TokenLevel.None)]
    public class BmsPointController : BaseController {
        /// <summary>
        /// 客服 - 新增客服加/扣點紀錄
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddPointHistory")]
        public Task<Response<AddPointHistoryRs>> AddPointHistory(Request<AddPointHistoryRq> request) => SvcRepo.Resolve<AddPointHistory>().RunAsync(request);
    }
}