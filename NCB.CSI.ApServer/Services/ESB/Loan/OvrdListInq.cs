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
    ///  逾期未繳款查詢
    /// </summary>
    [EsbTxnId("LO32")]
    public class OvrdListInq : EsbService<OvrdListInqRq, OvrdListInqRs> {
        public override async Task<(OvrdListInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(OvrdListInqRq model) => EsbResult(await PostAsync(model));
    }
}