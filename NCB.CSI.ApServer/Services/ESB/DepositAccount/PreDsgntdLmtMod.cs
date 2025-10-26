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
    ///  約定轉帳個人額度調整
    /// </summary>
    [EsbTxnId("DA17")]
    public class PreDsgntdLmtMod : EsbService<PreDsgntdLmtModRq, PreDsgntdLmtModRs> {
        public override async Task<(PreDsgntdLmtModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PreDsgntdLmtModRq model) => EsbResult(await PostAsync(model));
    }

}