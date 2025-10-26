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
    ///  卡片帳務費用調整
    /// </summary>
    [EsbTxnId("DC27")]
    public class DbCardTxnAcidntDtlsMod : EsbService<DbCardTxnAcidntDtlsModRq, DbCardTxnAcidntDtlsModRs> {
        public override async Task<(DbCardTxnAcidntDtlsModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardTxnAcidntDtlsModRq model) => EsbResult(await PostAsync(model));
    }
}