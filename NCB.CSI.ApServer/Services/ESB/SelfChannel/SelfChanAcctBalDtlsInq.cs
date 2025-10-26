using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.SelfChannel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.SelfChannel {
    /// <summary>
    /// 自動化當日可用餘額
    /// </summary>
    [EsbTxnId("SC01")]
    public class SelfChanAcctBalDtlsInq : EsbService<SelfChanAcctBalDtlsInqRq, SelfChanAcctBalDtlsInqRs> {
        public override async Task<(SelfChanAcctBalDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(SelfChanAcctBalDtlsInqRq model) => EsbResult(await PostAsync(model));
    }
}