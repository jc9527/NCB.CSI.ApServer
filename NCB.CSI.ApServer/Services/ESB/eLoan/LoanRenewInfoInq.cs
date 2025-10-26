using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.eLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.eLoan {
    /// <summary>
    ///  取得續約資料查詢
    /// </summary>
    [EsbTxnId("EL25")]
    public class LoanRenewInfoInq : EsbService<LoanRenewInfoInqRq, LoanRenewInfoInqRs> {
        public override async Task<(LoanRenewInfoInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanRenewInfoInqRq model) => EsbResult(await PostAsync(model));
    }
}