using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DepositAccount;

namespace NCB.CSI.ApServer.Services.ESB.DepositAccount {
    /// <summary>
    /// 關戶
    /// </summary>
    [EsbTxnId("DA29")]
    public class AcctCls : EsbService<AcctClsRq, AcctClsRs> {
        public override async Task<(AcctClsRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcctClsRq model) => EsbResult(await PostAsync(model));
    }
}