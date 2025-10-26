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
    ///  卡片帳務費用調整查詢
    /// </summary>
    [EsbTxnId("DC26")]
    public class DbCardTxnAcidntDtlsInq : EsbService<DbCardTxnAcidntDtlsInqRq, DbCardTxnAcidntDtlsInqRs> {
        public override async Task<(DbCardTxnAcidntDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardTxnAcidntDtlsInqRq model) => EsbResult(await PostAsync(model));
    }
}