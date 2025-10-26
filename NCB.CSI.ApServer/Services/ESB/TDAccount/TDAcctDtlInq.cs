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
    /// 定存主檔查詢
    /// </summary>
    [EsbTxnId("TD01")]
    public class TDAcctDtlInq : EsbService<TDAcctDtlInqRq, TDAcctDtlInqRs> {
        public override async Task<(TDAcctDtlInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDAcctDtlInqRq model) => EsbResult(await PostAsync(model));
    }
}