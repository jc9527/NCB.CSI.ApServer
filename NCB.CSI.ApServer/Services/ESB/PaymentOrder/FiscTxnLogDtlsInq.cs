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
    ///  自跨行帳務交易紀錄-交易明細
    /// </summary>
    [EsbTxnId("PO03")]
    public class FiscTxnLogDtlsInq : EsbService<FiscTxnLogDtlsInqRq, FiscTxnLogDtlsInqRs> {
        public override async Task<(FiscTxnLogDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(FiscTxnLogDtlsInqRq model) => EsbResult(await PostAsync(model));
    }
}