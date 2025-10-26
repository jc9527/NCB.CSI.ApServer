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
    ///  退稅交易
    /// </summary>
    [EsbTxnId("CT03")]
    public class RefndWHTAdd : EsbService<RefndWHTAddRq, RefndWHTAddRs> {
        public override async Task<(RefndWHTAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(RefndWHTAddRq model) => EsbResult(await PostAsync(model));
    }
}