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
    ///  開單前模擬及查詢合併
    /// </summary>
    [EsbTxnId("TD15")]
    public class TDAcctOpnCalInq : EsbService<TDAcctOpnCalInqRq, TDAcctOpnCalInqRs> {
        public override async Task<(TDAcctOpnCalInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDAcctOpnCalInqRq model) => EsbResult(await PostAsync(model));
    }

}