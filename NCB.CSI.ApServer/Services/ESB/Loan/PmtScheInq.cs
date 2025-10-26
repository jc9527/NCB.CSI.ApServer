using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.Loan {
    /// <summary>
    ///  還款時程表查詢
    /// </summary>
    [EsbTxnId("LO26")]
    public class PmtScheInq : EsbService<PmtScheInqRq, PmtScheInqRs> {
        public override async Task<(PmtScheInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PmtScheInqRq model) => EsbResult(await PostAsync(model));
    }
}