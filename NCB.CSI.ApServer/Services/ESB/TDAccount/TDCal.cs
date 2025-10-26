using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.TDAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.TDAccount {
    /// <summary>
    ///  開定存單前模擬
    /// </summary>
    [EsbTxnId("TD12")]
    public class TDCal : EsbService<TDCalRq, TDCalRs> {
        public override async Task<(TDCalRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDCalRq model) => EsbResult(await PostAsync(model));
    }
}