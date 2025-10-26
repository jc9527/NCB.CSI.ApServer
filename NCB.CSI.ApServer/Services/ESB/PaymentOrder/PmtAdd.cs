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
    ///  開戶交易與跨行交易
    /// </summary>
    [EsbTxnId("PO05")]
    public class PmtAdd : EsbService<PmtAddRq, PmtAddRs> {
        public override async Task<(PmtAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PmtAddRq model) => EsbResult(await PostAsync(model));
    }
}