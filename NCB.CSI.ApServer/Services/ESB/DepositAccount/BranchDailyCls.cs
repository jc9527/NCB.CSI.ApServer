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
    ///  分行關閉
    /// </summary>
    [EsbTxnId("DA32")]
    public class BranchDailyCls : EsbService<BranchDailyClsRq, BranchDailyClsRs> {
        public override async Task<(BranchDailyClsRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BranchDailyClsRq model) => EsbResult(await PostAsync(model));
    }

}