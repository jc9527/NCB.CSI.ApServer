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
    /// 銷戶查詢
    /// </summary>
    [EsbTxnId("DA09")]
    public class AcctClsInq : EsbService<AcctClsInqRq, AcctClsInqRs> {
        public override async Task<(AcctClsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcctClsInqRq model) => EsbResult(await PostAsync(model));
    }
}