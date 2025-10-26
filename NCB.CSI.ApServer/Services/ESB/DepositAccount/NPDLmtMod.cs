using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DepositAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DepositAccount {
    /// <summary>
    /// 變更非約轉帳限額
    /// </summary>
    [EsbTxnId("DA22")]
    public class NPDLmtMod : EsbService<NPDLmtModRq, NPDLmtModRs> {
        public override async Task<(NPDLmtModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(NPDLmtModRq model) => EsbResult(await PostAsync(model));
    }
}