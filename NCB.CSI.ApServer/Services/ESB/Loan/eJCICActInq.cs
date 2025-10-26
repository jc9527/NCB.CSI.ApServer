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
    ///  JCIC Z21及Z22查詢
    /// </summary>
    [EsbTxnId("LO03")]
    public class eJCICActInq : EsbService<eJCICActInqRq, eJCICActInqRs> {
        public override async Task<(eJCICActInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(eJCICActInqRq model) => EsbResult(await PostAsync(model));
    }
}