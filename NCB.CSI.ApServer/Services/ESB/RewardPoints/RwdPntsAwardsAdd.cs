using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.RewardPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.RewardPoints {
    /// <summary>
    ///  加(含取消)客戶點數
    /// </summary>
    [EsbTxnId("RP04")]
    public class RwdPntsAwardsAdd : EsbService<RwdPntsAwardsAddRq, RwdPntsAwardsAddRs> {
        public override async Task<(RwdPntsAwardsAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(RwdPntsAwardsAddRq model) => EsbResult(await PostAsync(model));
    }

}