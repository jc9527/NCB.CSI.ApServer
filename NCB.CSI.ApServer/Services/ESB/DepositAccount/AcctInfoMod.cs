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
    /// 更新帳戶別名
    /// </summary>
    [EsbTxnId("DA21")]
    public class AcctInfoMod : EsbService<AcctInfoModRq, AcctInfoModRs> {
        public override async Task<(AcctInfoModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcctInfoModRq model) => EsbResult(await PostAsync(model));
    }
}