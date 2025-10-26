using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DebitCard {
    /// <summary>
    ///  卡片消費帳單查詢
    /// </summary>
    [EsbTxnId("DC21")]
    public class TxnAcidntInq : EsbService<TxnAcidntInqRq, TxnAcidntInqRs> {
        public override async Task<(TxnAcidntInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TxnAcidntInqRq model) => EsbResult(await PostAsync(model));
    }
}