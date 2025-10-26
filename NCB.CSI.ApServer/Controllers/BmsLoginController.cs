using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.Login;
using NCB.CSI.Models.BMS.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/Login")]
    [JwtValidation(TokenLevel.None)]
    public class BmsLoginController : BaseController {
        /// <summary>
        /// 客服-查詢開戶進件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetLoginInfo")]
        public Task<Response<GetLoginInfoRs>> GetLoginInfo(Request<GetLoginInfoRq> request) => SvcRepo.Resolve<GetLoginInfo>().RunAsync(request);
    }
}