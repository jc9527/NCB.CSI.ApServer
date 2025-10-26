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
    ///  回覆續約或不續約
    /// </summary>
    [EsbTxnId("EL26")]
    public class LoanRenewStatMod : EsbService<LoanRenewStatModRq, LoanRenewStatModRs> {
        public override async Task<(LoanRenewStatModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanRenewStatModRq model) => EsbResult(await PostAsync(model));
    }
}