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
    ///  VD卡調整設定歷史查詢
    /// </summary>
    [EsbTxnId("DC07")]
    public class DbCardInstlmtInq : EsbService<DbCardInstlmtInqRq, DbCardInstlmtInqRs> {
        public override async Task<(DbCardInstlmtInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardInstlmtInqRq model) => EsbResult(await PostAsync(model));
    }
}