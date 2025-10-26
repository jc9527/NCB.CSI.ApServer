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
    ///  案件狀態查詢
    /// </summary>
    [EsbTxnId("EL21")]
    public class LoanAppStatInq : EsbService<LoanAppStatInqRq, LoanAppStatInqRs> {
        public override async Task<(LoanAppStatInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanAppStatInqRq model) => EsbResult(await PostAsync(model));
    }

}