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
    ///  定存續存條件變更
    /// </summary>
    [EsbTxnId("TD08")]
    public class TDCtrctContMod : EsbService<TDCtrctContModRq, TDCtrctContModRs> {
        public override async Task<(TDCtrctContModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDCtrctContModRq model) => EsbResult(await PostAsync(model));
    }

}