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
    ///  手續費種類查詢
    /// </summary>
    [EsbTxnId("DA26")]
    public class HdlgChrgListInq : EsbService<HdlgChrgListInqRq, HdlgChrgListInqRs> {
        public override async Task<(HdlgChrgListInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(HdlgChrgListInqRq model) => EsbResult(await PostAsync(model));
    }
}