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
    /// 約定轉出入帳號紀錄查詢
    /// </summary>
    [EsbTxnId("DA01")]
    public class PreDsgntdAcctHistInq : EsbService<PreDsgntdAcctHistInqRq, PreDsgntdAcctHistInqRs>
    {
        public override async Task<(PreDsgntdAcctHistInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PreDsgntdAcctHistInqRq model) => EsbResult(await PostAsync(model));
    }

}