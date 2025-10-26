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
using NCB.CSI.ApServer.Services.ESB.BankCard;
using NCB.CSI.Models.ESB.BankCard;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/BankCard")]
    [JwtValidation(TokenLevel.None)]
    public class EsbBankCardController : BaseController {
        /// <summary>
        /// 卡片最新資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardSummInq")]
        public Task<Response<BankCardSummInqRs>> BankCardSummInq(Request<BankCardSummInqRq> request) {
            var B = SvcRepo.Resolve<BankCardSummInq>().RunAsync(request);
            var status = Request.CreateResponse(HttpStatusCode.OK, B);
            //System.Web.HttpResponse dd =  System.Web.HttpResponse;
            return B;
        }
        //public Task<Response<BankCardSummInqRs>> BankCardSummInq(Request<BankCardSummInqRq> request) => SvcRepo.Resolve<BankCardSummInq>().RunAsync(request);
        /// <summary>
        /// 卡片資料查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardAppStatInq")]
        public Task<Response<BankCardAppStatInqRs>> FiscTxnLogSummInq(Request<BankCardAppStatInqRq> request) => SvcRepo.Resolve<BankCardAppStatInq>().RunAsync(request);
        /// <summary>
        ///  卡片補換發
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardResnd")]
        public Task<Response<BankCardResndRs>> BankCardResnd(Request<BankCardResndRq> request) => SvcRepo.Resolve<BankCardResnd>().RunAsync(request);
        /// <summary>
        ///  卡片新申請
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardApp")]
        public Task<Response<BankCardAppRs>> BankCardApp(Request<BankCardAppRq> request) => SvcRepo.Resolve<BankCardApp>().RunAsync(request);
        /// <summary>
        ///  卡片事故申請
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardRgstr")]
        public Task<Response<BankCardRgstrRs>> BankCardRgstr(Request<BankCardRgstrRq> request) => SvcRepo.Resolve<BankCardRgstr>().RunAsync(request);
        /// <summary>
        ///  卡片啟用
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardOpen")]
        public Task<Response<BankCardOpenRs>> BankCardOpen(Request<BankCardOpenRq> request) => SvcRepo.Resolve<BankCardOpen>().RunAsync(request);
        /// <summary>
        ///  歷史卡況查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardHistInq")]
        public Task<Response<BankCardHistInqRs>> BankCardHistInq(Request<BankCardHistInqRq> request) => SvcRepo.Resolve<BankCardHistInq>().RunAsync(request);
        /// <summary>
        ///  卡片補換發檢核
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardResndChk")]
        public Task<Response<BankCardResndChkRs>> BankCardResndChk(Request<BankCardResndChkRq> request) => SvcRepo.Resolve<BankCardResndChk>().RunAsync(request);
        /// <summary>
        ///  卡片事故紀錄查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardAcidntInq")]
        public Task<Response<BankCardAcidntInqRs>> BankCardAcidntInq(Request<BankCardAcidntInqRq> request) => SvcRepo.Resolve<BankCardAcidntInq>().RunAsync(request);
        /// <summary>
        ///  換補發歷史紀錄查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BankCardResndHistInq")]
        public Task<Response<BankCardResndHistInqRs>> BankCardResndHistInq(Request<BankCardResndHistInqRq> request) => SvcRepo.Resolve<BankCardResndHistInq>().RunAsync(request);
        /// <summary>
        ///  是否收事故費用查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcidntFeeInq")]
        public Task<Response<AcidntFeeInqRs>> AcidntFeeInq(Request<AcidntFeeInqRq> request) => SvcRepo.Resolve<AcidntFeeInq>().RunAsync(request);
        /// <summary>
        ///  卡片狀態異動
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("WdlCardFnctMod")]
        public Task<Response<WdlCardFnctModRs>> WdlCardFnctMod(Request<WdlCardFnctModRq> request) => SvcRepo.Resolve<WdlCardFnctMod>().RunAsync(request);
    }
}
