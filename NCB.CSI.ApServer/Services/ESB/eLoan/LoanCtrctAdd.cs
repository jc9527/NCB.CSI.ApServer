using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB;
using NCB.CSI.Models.ESB.eLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.eLoan {
    /// <summary>
    ///  同意契約內容
    /// </summary>
    [EsbTxnId("EL19")]
    public class LoanCtrctAdd : EsbService<LoanCtrctAddRq, LoanCtrctAddRs> {
        public override async Task<(LoanCtrctAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanCtrctAddRq model) => EsbResult(await PostAsync(model));
    }
}