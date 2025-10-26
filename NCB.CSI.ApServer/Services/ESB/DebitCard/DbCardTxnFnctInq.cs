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
    ///  卡片交易功能查詢
    /// </summary>
    [EsbTxnId("DC19")]
    public class DbCardTxnFnctInq : EsbService<DbCardTxnFnctInqRq, DbCardTxnFnctInqRs> {
        public override async Task<(DbCardTxnFnctInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardTxnFnctInqRq model) => EsbResult(await PostAsync(model));
    }
}