using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.CustomerTax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.CustomerTax {
    /// <summary>
    ///  補入差息
    /// </summary>
    [EsbTxnId("CT04")]
    public class CrAdjIntrstAdd : EsbService<CrAdjIntrstAddRq, CrAdjIntrstAddRs> {
        public override async Task<(CrAdjIntrstAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CrAdjIntrstAddRq model) => EsbResult(await PostAsync(model));
    }
}