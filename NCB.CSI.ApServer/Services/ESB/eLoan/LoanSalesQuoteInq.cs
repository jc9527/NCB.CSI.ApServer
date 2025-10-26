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
    ///  申請報價查詢
    /// </summary>
    [EsbTxnId("EL22")]
    public class LoanSalesQuoteInq : EsbService<LoanSalesQuoteInqRq, LoanSalesQuoteInqRs> {
        public override async Task<(LoanSalesQuoteInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanSalesQuoteInqRq model) => EsbResult(await PostAsync(model));
    }
}