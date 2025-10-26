using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.Deposit;
using NCB.CSI.Models.BMS.Deposit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/Deposit")]
    [JwtValidation(TokenLevel.None)]
    public class BmsDepositController : BaseController {
        /// <summary>
        /// 客作服 - 取得客戶帳戶列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PocketList")]
        public Task<Response<PocketListRs>> PocketList(Request<PocketListRq> request) => SvcRepo.Resolve<PocketList>().RunAsync(request);
    }
}