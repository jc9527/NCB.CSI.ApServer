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
    ///  未付息明細查詢
    /// </summary>
    [EsbTxnId("DA24")]
    public class AccrdIntrstInq : EsbService<AccrdIntrstInqRq, AccrdIntrstInqRs>
    {
        public override async Task<(AccrdIntrstInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AccrdIntrstInqRq model) => EsbResult(await PostAsync(model));
    }
}