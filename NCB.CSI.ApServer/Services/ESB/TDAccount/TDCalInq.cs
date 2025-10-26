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
    ///  開單前模擬查詢
    /// </summary>
    [EsbTxnId("TD13")]
    public class TDCalInq : EsbService<TDCalInqRq, TDCalInqRs> {
        public override async Task<(TDCalInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDCalInqRq model) => EsbResult(await PostAsync(model));
    }
}