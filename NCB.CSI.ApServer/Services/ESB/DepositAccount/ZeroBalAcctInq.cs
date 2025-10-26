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
    ///  零餘額帳戶查詢
    /// </summary>
    [EsbTxnId("DA31")]
    public class ZeroBalAcctInq : EsbService<ZeroBalAcctInqRq, ZeroBalAcctInqRs>
    {
        public override async Task<(ZeroBalAcctInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(ZeroBalAcctInqRq model) => EsbResult(await PostAsync(model));
    }
}