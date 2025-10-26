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
    ///  FXML交易紀錄查詢
    /// </summary>
    [EsbTxnId("PO06")]
    public class PmtInq : EsbService<PmtInqRq, PmtInqRs> {
        public override async Task<(PmtInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PmtInqRq model) => EsbResult(await PostAsync(model));
    }

}