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
    ///  簽帳卡消費限額維護
    /// </summary>
    [EsbTxnId("DC05")]
    public class DbCardLmtMod : EsbService<DbCardLmtModRq, DbCardLmtModRs> {
        public override async Task<(DbCardLmtModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardLmtModRq model) => EsbResult(await PostAsync(model));
    }
}