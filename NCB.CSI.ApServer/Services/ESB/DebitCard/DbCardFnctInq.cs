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
    ///  簽帳卡卡片功能查詢
    /// </summary>
    [EsbTxnId("DC02")]
    public class DbCardFnctInq : EsbService<DbCardFnctInqRq, DbCardFnctInqRs> {
        public override async Task<(DbCardFnctInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardFnctInqRq model) => EsbResult(await PostAsync(model));
    }
}