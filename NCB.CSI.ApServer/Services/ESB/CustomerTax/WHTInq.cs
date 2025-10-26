using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.CustomerTax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.CustomerTax {
    /// <summary>
    ///  年度代扣利息所得稅查詢
    /// </summary>
    [EsbTxnId("CT01")]
    public class WHTInq : EsbService<WHTInqRq, WHTInqRs> {
        public override async Task<(WHTInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(WHTInqRq model) => EsbResult(await PostAsync(model));
    }
}