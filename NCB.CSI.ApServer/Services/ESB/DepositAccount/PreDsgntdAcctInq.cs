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
    /// 約定轉出入帳號查詢
    /// </summary>
    [EsbTxnId("DA05")]
    public class PreDsgntdAcctInq : EsbService<PreDsgntdAcctInqRq, PreDsgntdAcctInqRs> {
        public override async Task<(PreDsgntdAcctInqRs Result, string ResultCode, string ResultMessage)>
             RunAsync(PreDsgntdAcctInqRq model) => EsbResult(await PostAsync(model));
    }
}