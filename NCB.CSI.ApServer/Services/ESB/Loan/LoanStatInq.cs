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
    ///  放款狀態查詢
    /// </summary>
    [EsbTxnId("LO35")]
    public class LoanStatInq : EsbService<LoanStatInqRq, LoanStatInqRs> {
        public override async Task<(LoanStatInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanStatInqRq model) => EsbResult(await PostAsync(model));
    }
}