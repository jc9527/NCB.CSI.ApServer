using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.eLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.eLoan {
    /// <summary>
    ///  檢視契據
    /// </summary>
    [EsbTxnId("EL24")]
    public class PrectrctInq : EsbService<PrectrctInqRq, PrectrctInqRs> {
        public override async Task<(PrectrctInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PrectrctInqRq model) => EsbResult(await PostAsync(model));
    }
}