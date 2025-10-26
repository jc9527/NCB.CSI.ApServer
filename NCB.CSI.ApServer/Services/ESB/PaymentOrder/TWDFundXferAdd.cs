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
    ///  台幣帳號轉帳
    /// </summary>
    [EsbTxnId("PO04")]
    public class TWDFundXferAdd : EsbService<TWDFundXferAddRq, TWDFundXferAddRs> {
        public override async Task<(TWDFundXferAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TWDFundXferAddRq model) => EsbResult(await PostAsync(model));
    }

}