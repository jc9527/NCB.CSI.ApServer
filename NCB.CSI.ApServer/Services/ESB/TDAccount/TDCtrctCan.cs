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
    ///  定存中途解約作業
    /// </summary>
    [EsbTxnId("TD04")]
    public class TDCtrctCan : EsbService<TDCtrctCanRq, TDCtrctCanRs> {
        public override async Task<(TDCtrctCanRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDCtrctCanRq model) => EsbResult(await PostAsync(model));
    }
}