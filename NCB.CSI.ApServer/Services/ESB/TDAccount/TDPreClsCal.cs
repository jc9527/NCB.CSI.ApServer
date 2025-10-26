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
    ///  查詢中途解約後可領金額
    /// </summary>
    [EsbTxnId("TD14")]
    public class TDPreClsCal : EsbService<TDPreClsCalRq, TDPreClsCalRs>
    {
        public override async Task<(TDPreClsCalRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDPreClsCalRq model) => EsbResult(await PostAsync(model));
    }
}