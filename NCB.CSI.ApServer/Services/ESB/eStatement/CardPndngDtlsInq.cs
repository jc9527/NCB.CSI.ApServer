using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.eStatement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.eStatement {
    /// <summary>
    ///  卡片帳單未出帳明細
    /// </summary>
    [EsbTxnId("ES03")]
    public class CardPndngDtlsInq : EsbService<CardPndngDtlsInqRq, CardPndngDtlsInqRs> {
        public override async Task<(CardPndngDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CardPndngDtlsInqRq model) => EsbResult(await PostAsync(model));
    }
}