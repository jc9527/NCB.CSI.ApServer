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
    ///  卡片預約續卡查詢
    /// </summary>
    [EsbTxnId("DC17")]
    public class DbCardResndAppntInq : EsbService<DbCardResndAppntInqRq, DbCardResndAppntInqRs> {
        public override async Task<(DbCardResndAppntInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardResndAppntInqRq model) => EsbResult(await PostAsync(model));
    }
}