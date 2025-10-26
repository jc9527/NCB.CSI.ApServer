using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.Payment {
    /// <summary>
    ///  卡片線上解圈
    /// </summary>
    [EsbTxnId("PA04")]
    public class UnlockAdd : EsbService<UnlockAddRq, UnlockAddRs> {
        public override async Task<(UnlockAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UnlockAddRq model) => EsbResult(await PostAsync(model));
    }
}