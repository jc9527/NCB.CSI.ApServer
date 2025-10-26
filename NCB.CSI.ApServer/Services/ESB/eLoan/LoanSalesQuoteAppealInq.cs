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
    ///  變更報價查詢
    /// </summary>
    [EsbTxnId("EL23")]
    public class LoanSalesQuoteAppealInq : EsbService<LoanSalesQuoteAppealInqRq, LoanSalesQuoteAppealInqRs> {
        public override async Task<(LoanSalesQuoteAppealInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanSalesQuoteAppealInqRq model) => EsbResult(await PostAsync(model));
    }
}