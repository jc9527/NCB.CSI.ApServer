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
    ///  VD卡授權明細查詢
    /// </summary>
    [EsbTxnId("DC06")]
    public class DbCardLockDtlsInq : EsbService<DbCardLockDtlsInqRq, DbCardLockDtlsInqRs> {
        public override async Task<(DbCardLockDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardLockDtlsInqRq model) => EsbResult(await PostAsync(model));
    }
}