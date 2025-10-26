using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.BankCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.BankCard {
    /// <summary>
    ///  卡片狀態異動
    /// </summary>
    [EsbTxnId("BC13")]
    public class WdlCardFnctMod : EsbService<WdlCardFnctModRq, WdlCardFnctModRs> {
        public override async Task<(WdlCardFnctModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(WdlCardFnctModRq model) => EsbResult(await PostAsync(model));
    }
}