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
    ///  帳戶圈存查詢
    /// </summary>
    [EsbTxnId("DA20")]
    public class AcctPostRstrctHistInq : EsbService<AcctPostRstrctHistInqRq, AcctPostRstrctHistInqRs>
    {
        public override async Task<(AcctPostRstrctHistInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcctPostRstrctHistInqRq model) => EsbResult(await PostAsync(model));
    }
}