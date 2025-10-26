using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.CurrentAccount;

namespace NCB.CSI.ApServer.Services.ESB.CurrentAccount {
    /// <summary>
    /// 帳號明細查詢
    /// </summary>
    [EsbTxnId("CA05")]
    public class AcctDtlInq : EsbService<AcctDtlInqRq, AcctDtlInqRs> {
        public override async Task<(AcctDtlInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcctDtlInqRq model) => EsbResult(await PostAsync(model));
    }
}