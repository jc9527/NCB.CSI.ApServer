using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Base;
using NCB.CSI.ApServer.Services.ESB.DebitCard;
using NCB.CSI.Models.ESB.DebitCard;
using System.Web.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.Token;
using Devpro.Shared.ActionFilters;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/DebitCard")]
    [JwtValidation(TokenLevel.None)]
    public class EsbDebitCardController : BaseController {
        /// <summary>
        /// 簽帳卡交易明細查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardTxnDtlsInq")]
        public Task<Response<DbCardTxnDtlsInqRs>> DbCardTxnDtlsInq(Request<DbCardTxnDtlsInqRq> request) => SvcRepo.Resolve<DbCardTxnDtlsInq>().RunAsync(request);
        /// <summary>`
        /// 簽帳卡卡片功能查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardFnctInq")]
        public Task<Response<DbCardFnctInqRs>> DbCardFnctInq(Request<DbCardFnctInqRq> request) => SvcRepo.Resolve<DbCardFnctInq>().RunAsync(request);
        /// <summary>
        ///簽帳卡消費限額查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardLmtInq")]
        public Task<Response<DbCardLmtInqRs>> DbCardLmtInq(Request<DbCardLmtInqRq> request) => SvcRepo.Resolve<DbCardLmtInq>().RunAsync(request);
        /// <summary>
        ///  VD卡授權明細查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardLockDtlsInq")]
        public Task<Response<DbCardLockDtlsInqRs>> DbCardLockDtlsInq(Request<DbCardLockDtlsInqRq> request) => SvcRepo.Resolve<DbCardLockDtlsInq>().RunAsync(request);
        /// <summary>
        ///  VD卡調整設定歷史查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardInstlmtInq")]
        public Task<Response<DbCardInstlmtInqRs>> DbCardInstlmtInq(Request<DbCardInstlmtInqRq> request) => SvcRepo.Resolve<DbCardInstlmtInq>().RunAsync(request);
        /// <summary>
        ///  VD卡客戶基本資料查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CardCIFInfoInq")]
        public Task<Response<CardCIFInfoInqRs>> CardCIFInfoInq(Request<CardCIFInfoInqRq> request) => SvcRepo.Resolve<CardCIFInfoInq>().RunAsync(request);
        /// <summary>
        ///  卡片交易帳號查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardLockAcctInq")]
        public Task<Response<DbCardLockAcctInqRs>> DbCardLockAcctInq(Request<DbCardLockAcctInqRq> request) => SvcRepo.Resolve<DbCardLockAcctInq>().RunAsync(request);
        /// <summary>
        ///  卡片預約續卡查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardResndAppntInq")]
        public Task<Response<DbCardResndAppntInqRs>> DbCardResndAppntInq(Request<DbCardResndAppntInqRq> request) => SvcRepo.Resolve<DbCardResndAppntInq>().RunAsync(request);
        /// <summary>
        ///  卡片交易功能查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardTxnFnctInq")]
        public Task<Response<DbCardTxnFnctInqRs>> DbCardTxnFnctInq(Request<DbCardTxnFnctInqRq> request) => SvcRepo.Resolve<DbCardTxnFnctInq>().RunAsync(request);
        /// <summary>
        ///  卡片消費帳單查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TxnAcidntInq")]
        public Task<Response<TxnAcidntInqRs>> TxnAcidntInq(Request<TxnAcidntInqRq> request) => SvcRepo.Resolve<TxnAcidntInq>().RunAsync(request);
        /// <summary>
        ///  卡片國外提領預借現金密碼錯誤次數查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("XbrdWdlCardPswdCntInq")]
        public Task<Response<XbrdWdlCardPswdCntInqRs>> XbrdWdlCardPswdCntInq(Request<XbrdWdlCardPswdCntInqRq> request) => SvcRepo.Resolve<XbrdWdlCardPswdCntInq>().RunAsync(request);
        /// <summary>
        ///  卡片國外提領預借現金密碼錯誤次數歸零
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("XbrdWdlCardPswdCntMod")]
        public Task<Response<XbrdWdlCardPswdCntModRs>> XbrdWdlCardPswdCntMod(Request<XbrdWdlCardPswdCntModRq> request) => SvcRepo.Resolve<XbrdWdlCardPswdCntMod>().RunAsync(request);
        /// <summary>
        ///  卡片帳務費用調整查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardTxnAcidntDtlsInq")]
        public Task<Response<DbCardTxnAcidntDtlsInqRs>> DbCardTxnAcidntDtlsInq(Request<DbCardTxnAcidntDtlsInqRq> request) => SvcRepo.Resolve<DbCardTxnAcidntDtlsInq>().RunAsync(request);
        /// <summary>
        ///  卡片帳務費用查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardFeeInq")]
        public Task<Response<DbCardFeeInqRs>> DbCardFeeInq(Request<DbCardFeeInqRq> request) => SvcRepo.Resolve<DbCardFeeInq>().RunAsync(request);
        /// <summary>
        ///  簽帳卡更改管制
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardChngCtrl")]
        public Task<Response<DbCardChngCtrlRs>> DbCardChngCtrl(Request<DbCardChngCtrlRq> request) => SvcRepo.Resolve<DbCardChngCtrl>().RunAsync(request);
        /// <summary>
        ///  簽帳卡消費限額維護
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardLmtMod")]
        public Task<Response<DbCardLmtModRs>> DbCardLmtMod(Request<DbCardLmtModRq> request) => SvcRepo.Resolve<DbCardLmtMod>().RunAsync(request);
        /// <summary>
        ///  卡況異動   
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CardMod")]
        public Task<Response<CardModRs>> CardMod(Request<CardModRq> request) => SvcRepo.Resolve<CardMod>().RunAsync(request);
        /// <summary>
        ///  卡片續卡設定
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardResndAppntAdd")]
        public Task<Response<DbCardResndAppntAddRs>> DbCardResndAppntAdd(Request<DbCardResndAppntAddRq> request) => SvcRepo.Resolve<DbCardResndAppntAdd>().RunAsync(request);
        /// <summary>
        ///  卡片交易功能變更
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardTxnFnctMod")]
        public Task<Response<DbCardTxnFnctModRs>> DbCardTxnFnctMod(Request<DbCardTxnFnctModRq> request) => SvcRepo.Resolve<DbCardTxnFnctMod>().RunAsync(request);
        /// <summary>
        ///  卡片帳務費用新增
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardFeeAdd")]
        public Task<Response<DbCardFeeAddRs>> DbCardFeeAdd(Request<DbCardFeeAddRq> request) => SvcRepo.Resolve<DbCardFeeAdd>().RunAsync(request);
        /// <summary>
        ///  卡片帳務費用調整
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbCardTxnAcidntDtlsMod")]
        public Task<Response<DbCardTxnAcidntDtlsModRs>> DbCardTxnAcidntDtlsMod(Request<DbCardTxnAcidntDtlsModRq> request) => SvcRepo.Resolve<DbCardTxnAcidntDtlsMod>().RunAsync(request);
    }
}