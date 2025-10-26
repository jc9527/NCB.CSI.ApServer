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
    ///  卡片交易帳號查詢
    /// </summary>
    [EsbTxnId("DC15")]
    public class DbCardLockAcctInq : EsbService<DbCardLockAcctInqRq, DbCardLockAcctInqRs> {
        public override async Task<(DbCardLockAcctInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardLockAcctInqRq model) => EsbResult(await PostAsync(model));
    }
}