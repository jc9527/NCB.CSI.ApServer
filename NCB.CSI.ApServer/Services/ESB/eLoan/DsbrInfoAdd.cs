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
    ///  撥款資訊
    /// </summary>
    [EsbTxnId("EL27")]
    public class DsbrInfoAdd : EsbService<DsbrInfoAddRq, DsbrInfoAddRs> {
        public override async Task<(DsbrInfoAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DsbrInfoAddRq model) => EsbResult(await PostAsync(model));
    }
}