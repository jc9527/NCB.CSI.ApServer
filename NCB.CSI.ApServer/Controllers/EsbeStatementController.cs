using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.eStatement;
using NCB.CSI.Models.ESB.eStatement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/eStatement")]
    [JwtValidation(TokenLevel.None)]
    public class EsbeStatementController : BaseController {
        /// <summary>
        ///  卡片帳單未出帳明細
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CardPndngDtlsInq")]
        public Task<Response<CardPndngDtlsInqRs>> CardPndngDtlsInq(Request<CardPndngDtlsInqRq> request) => SvcRepo.Resolve<CardPndngDtlsInq>().RunAsync(request);
        /// <summary>
        ///  綜合對帳單帳務資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("eStmtDtlsInq")]
        public Task<Response<eStmtDtlsInqRs>> eStmtDtlsInq(Request<eStmtDtlsInqRq> request) => SvcRepo.Resolve<eStmtDtlsInq>().RunAsync(request);
    }
}