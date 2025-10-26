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
    ///  圈存及解圈
    /// </summary>
    [EsbTxnId("PA01")]
    public class LockAdd : EsbService<LockAddRq, LockAddRs> {
        public override async Task<(LockAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(LockAddRq model) => EsbResult(await PostAsync(model));
    }
}