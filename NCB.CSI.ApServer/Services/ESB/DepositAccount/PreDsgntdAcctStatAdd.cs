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
    ///  約定轉帳設定
    /// </summary>
    [EsbTxnId("DA06")]
    public class PreDsgntdAcctStatAdd : EsbService<PreDsgntdAcctStatAddRq, PreDsgntdAcctStatAddRs> {
        public override async Task<(PreDsgntdAcctStatAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PreDsgntdAcctStatAddRq model) => EsbResult(await PostAsync(model));
    }
}