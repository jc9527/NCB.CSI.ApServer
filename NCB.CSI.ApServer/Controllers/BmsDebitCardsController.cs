using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.BMS.DebitCards;
using NCB.CSI.Models.BMS.DebitCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/DebitCards")]
    [JwtValidation(TokenLevel.None)]
    public class BmsDebitCardsController : BaseController {
        /// <summary>
        /// 作服 - 查詢客戶修改寄送地址紀錄
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetCheckAddrList")]
        public Task<Response<GetCheckAddrListRs>> GetCheckAddrList(Request<GetCheckAddrListRq> request) => SvcRepo.Resolve<GetCheckAddrList>().RunAsync(request);

        /// <summary>
        /// 作服 - 更新客戶修改寄送地址狀態
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateCheckAddrStatus")]
        public Task<Response<UpdateCheckAddrStatusRs>> UpdateCheckAddrStatus(Request<UpdateCheckAddrStatusRq> request) => SvcRepo.Resolve<UpdateCheckAddrStatus>().RunAsync(request);
    }
}