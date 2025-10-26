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
    ///  帳戶資訊變更查詢
    /// </summary>
    [EsbTxnId("DA27")]
    public class AcctInfoChngInq : EsbService<AcctInfoChngInqRq, AcctInfoChngInqRs>
    {
        public override async Task<(AcctInfoChngInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcctInfoChngInqRq model) => EsbResult(await PostAsync(model));
    }
}