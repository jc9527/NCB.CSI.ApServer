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
    /// 簽帳卡消費限額查詢				
    /// </summary>
    [EsbTxnId("DC04")]
    public class DbCardLmtInq : EsbService<DbCardLmtInqRq, DbCardLmtInqRs> {
        public override async Task<(DbCardLmtInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardLmtInqRq model) => EsbResult(await PostAsync(model));
    }
}