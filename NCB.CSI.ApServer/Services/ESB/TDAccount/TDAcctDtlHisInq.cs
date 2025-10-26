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
    /// 定存歷史查詢
    /// </summary>
    [EsbTxnId("TD17")]
    public class TDAcctDtlHisInq : EsbService<TDAcctDtlHisInqRq, TDAcctDtlHisInqRs> {
        public override async Task<(TDAcctDtlHisInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TDAcctDtlHisInqRq model) => EsbResult(await PostAsync(model));
    }
}