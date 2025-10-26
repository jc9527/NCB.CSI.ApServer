using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DepositAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DepositAccount
{
    /// <summary>
    ///  查詢財金日結
    /// </summary>
    [EsbTxnId("DA35")]
    public class FISCTxnSummInq : EsbService<FISCTxnSummInqRq, FISCTxnSummInqRs>
    {
        public override async Task<(FISCTxnSummInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(FISCTxnSummInqRq model) => EsbResult(await PostAsync(model));
    }
}