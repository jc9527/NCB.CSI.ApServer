using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.PaymentOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.PaymentOrder {
    /// <summary>
    /// 自跨行帳務交易紀錄-查詢摘要
    /// </summary>
    [EsbTxnId("PO02")]
    public class FiscTxnLogSummInq : EsbService<FiscTxnLogSummInqRq, FiscTxnLogSummInqRs> {
        public override async Task<(FiscTxnLogSummInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(FiscTxnLogSummInqRq model) => EsbResult(await PostAsync(model));
    }
}

