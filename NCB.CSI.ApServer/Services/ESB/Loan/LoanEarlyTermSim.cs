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
    ///  提貸款提前解約模擬試算及結果查詢
    /// </summary>
    [EsbTxnId("LO40")]
    public class LoanEarlyTermSim : EsbService<LoanEarlyTermSimRq, LoanEarlyTermSimRs> {
        public override async Task<(LoanEarlyTermSimRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LoanEarlyTermSimRq model) => EsbResult(await PostAsync(model));
    }
}