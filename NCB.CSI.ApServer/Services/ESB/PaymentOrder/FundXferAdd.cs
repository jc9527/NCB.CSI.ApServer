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
    ///  轉帳交易
    /// </summary>
    [EsbTxnId("PO08")]
    public class FundXferAdd : EsbService<FundXferAddRq, FundXferAddRs> {
        public override async Task<(FundXferAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(FundXferAddRq model) => EsbResult(await PostAsync(model));
    }
}