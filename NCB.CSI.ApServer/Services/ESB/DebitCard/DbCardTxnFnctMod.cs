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
    ///  卡片交易功能變更
    /// </summary>
    [EsbTxnId("DC20")]
    public class DbCardTxnFnctMod : EsbService<DbCardTxnFnctModRq, DbCardTxnFnctModRs> {
        public override async Task<(DbCardTxnFnctModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardTxnFnctModRq model) => EsbResult(await PostAsync(model));
    }
}