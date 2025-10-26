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
    ///  未授權交易清單查詢
    /// </summary>
    [EsbTxnId("DA30")]
    public class UnauthTxnListInq : EsbService<UnauthTxnListInqRq, UnauthTxnListInqRs>
    {
        public override async Task<(UnauthTxnListInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UnauthTxnListInqRq model) => EsbResult(await PostAsync(model));
    }
}