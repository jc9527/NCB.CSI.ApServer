using System.Threading.Tasks;
using System.Web.Http;
using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Base;
using NCB.CSI.ApServer.Services.ESB.DepositAccount;
using NCB.CSI.Models.ESB.DepositAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Devpro.Shared.Token;
using Devpro.Shared.ActionFilters;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/DepositAccount")]
    [JwtValidation(TokenLevel.None)]
    public class EsbDepositAccountController : BaseController {
        /// <summary>
        /// 銷戶查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcctClsInq")]
        public Task<Response<AcctClsInqRs>> AcctClsInq(Request<AcctClsInqRq> request) => SvcRepo.Resolve<AcctClsInq>().RunAsync(request);
        /// <summary>
        /// 關戶
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcctCls")]
        public Task<Response<AcctClsRs>> AcctCls(Request<AcctClsRq> request) => SvcRepo.Resolve<AcctCls>().RunAsync(request);
        /// <summary>
        /// 約定轉出入帳號查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PreDsgntdAcctInq")]
        public Task<Response<PreDsgntdAcctInqRs>> PreDsgntdAcctInq(Request<PreDsgntdAcctInqRq> request) => SvcRepo.Resolve<PreDsgntdAcctInq>().RunAsync(request);
        /// <summary>
        /// 約定轉出入帳號紀錄查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PreDsgntdAcctHistInq")]
        public Task<Response<PreDsgntdAcctHistInqRs>> PreDsgntdAcctHistInq(Request<PreDsgntdAcctHistInqRq> request) => SvcRepo.Resolve<PreDsgntdAcctHistInq>().RunAsync(request);
        /// <summary>
        /// 約定轉帳設定查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PreDsgntdAcctStatInq")]
        public Task<Response<PreDsgntdAcctStatInqRs>> PreDsgntdAcctStatInq(Request<PreDsgntdAcctStatInqRq> request) => SvcRepo.Resolve<PreDsgntdAcctStatInq>().RunAsync(request);
        /// <summary>
        /// 約定轉帳個人額度調整歷史查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PreDsgntdLmtHisInq")]
        public Task<Response<PreDsgntdLmtHisInqRs>> PreDsgntdLmtHisInq(Request<PreDsgntdLmtHisInqRq> request) => SvcRepo.Resolve<PreDsgntdLmtHisInq>().RunAsync(request);
        /// <summary>
        ///帳戶圈存查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcctPostRstrctHistInq")]
        public Task<Response<AcctPostRstrctHistInqRs>> AcctPostRstrctHistInq(Request<AcctPostRstrctHistInqRq> request) => SvcRepo.Resolve<AcctPostRstrctHistInq>().RunAsync(request);
        /// <summary>
        ///  未付息明細查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AccrdIntrstInq")]
        public Task<Response<AccrdIntrstInqRs>> AccrdIntrstInq(Request<AccrdIntrstInqRq> request) => SvcRepo.Resolve<AccrdIntrstInq>().RunAsync(request);
        /// <summary>
        ///  帳戶交易明細查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcctTxnDtlsInq")]
        public Task<Response<AcctTxnDtlsInqRs>> AcctTxnDtlsInq(Request<AcctTxnDtlsInqRq> request) => SvcRepo.Resolve<AcctTxnDtlsInq>().RunAsync(request);
        /// <summary>
        ///  手續費種類查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("HdlgChrgListInq")]
        public Task<Response<HdlgChrgListInqRs>> HdlgChrgListInq(Request<HdlgChrgListInqRq> request) => SvcRepo.Resolve<HdlgChrgListInq>().RunAsync(request);
        /// <summary>
        ///  帳戶資訊變更查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcctInfoChngInq")]
        public Task<Response<AcctInfoChngInqRs>> AcctInfoChngInq(Request<AcctInfoChngInqRq> request) => SvcRepo.Resolve<AcctInfoChngInq>().RunAsync(request);
        /// <summary>
        ///  未授權交易清單查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UnauthTxnListInq")]
        public Task<Response<UnauthTxnListInqRs>> UnauthTxnListInq(Request<UnauthTxnListInqRq> request) => SvcRepo.Resolve<UnauthTxnListInq>().RunAsync(request);
        /// <summary>
        ///  零餘額帳戶查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("ZeroBalAcctInq")]
        public Task<Response<ZeroBalAcctInqRs>> ZeroBalAcctInq(Request<ZeroBalAcctInqRq> request) => SvcRepo.Resolve<ZeroBalAcctInq>().RunAsync(request);
        /// <summary>
        ///  約定轉帳設定
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PreDsgntdAcctStatAdd")]
        public Task<Response<PreDsgntdAcctStatAddRs>> PreDsgntdAcctStatAdd(Request<PreDsgntdAcctStatAddRq> request) => SvcRepo.Resolve<PreDsgntdAcctStatAdd>().RunAsync(request);
        /// <summary>
        ///  約定轉帳個人額度調整
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("PreDsgntdLmtMod")]
        public Task<Response<PreDsgntdLmtModRs>> PreDsgntdLmtMod(Request<PreDsgntdLmtModRq> request) => SvcRepo.Resolve<PreDsgntdLmtMod>().RunAsync(request);
        /// <summary>
        ///  變更非約轉帳限額
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("NPDLmtMod")]
        public Task<Response<NPDLmtModRs>> NPDLmtMod(Request<NPDLmtModRq> request) => SvcRepo.Resolve<NPDLmtMod>().RunAsync(request);
        /// <summary>
        ///  更新帳戶別名
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AcctInfoMod")]
        public Task<Response<AcctInfoModRs>> AcctInfoMod(Request<AcctInfoModRq> request) => SvcRepo.Resolve<AcctInfoMod>().RunAsync(request);
        /// <summary>
        ///  交易限額查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("TxnLmtListInq")]
        public Task<Response<TxnLmtListInqRs>> TxnLmtListInq(Request<TxnLmtListInqRq> request) => SvcRepo.Resolve<TxnLmtListInq>().RunAsync(request);
        /// <summary>
        ///  分行關閉
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("BranchDailyCls")]
        public Task<Response<BranchDailyClsRs>> BranchDailyCls(Request<BranchDailyClsRq> request) => SvcRepo.Resolve<BranchDailyCls>().RunAsync(request);
        /// <summary>
        ///  查詢財金日結
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("FISCTxnSummInq")]
        public Task<Response<FISCTxnSummInqRs>> FISCTxnSummInq(Request<FISCTxnSummInqRq> request) => SvcRepo.Resolve<FISCTxnSummInq>().RunAsync(request);

    }
}