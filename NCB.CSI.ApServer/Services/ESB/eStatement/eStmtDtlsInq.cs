using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.eStatement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.eStatement {
    /// <summary>
    ///  綜合對帳單帳務資料
    /// </summary>
    [EsbTxnId("ES05")]
    public class eStmtDtlsInq : EsbService<eStmtDtlsInqRq, eStmtDtlsInqRs> {
        public override async Task<(eStmtDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(eStmtDtlsInqRq model) => EsbResult(await PostAsync(model));
    }
}