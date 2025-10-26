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
    ///  約定轉帳設定查詢
    /// </summary>
    [EsbTxnId("DA07")]
    public class PreDsgntdAcctStatInq : EsbService<PreDsgntdAcctStatInqRq, PreDsgntdAcctStatInqRs>
    {
        public override async Task<(PreDsgntdAcctStatInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PreDsgntdAcctStatInqRq model) => EsbResult(await PostAsync(model));
    }

}