using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.Wallet;
using NCB.CSI.Models.ESB.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/Wallet")]
    [JwtValidation(TokenLevel.None)]
    public class EsbWalletController : BaseController {
        /// <summary>
        ///  查詢一卡通基本資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("WalletProfInq")]
        public Task<Response<WalletProfInqRs>> WalletProfInq(Request<WalletProfInqRq> request) => SvcRepo.Resolve<WalletProfInq>().RunAsync(request);
        /// <summary>
        ///  自動加值資料查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("WalletAutoLoadInq")]
        public Task<Response<WalletAutoLoadInqRs>> WalletAutoLoadInq(Request<WalletAutoLoadInqRq> request) => SvcRepo.Resolve<WalletAutoLoadInq>().RunAsync(request);
    }
}