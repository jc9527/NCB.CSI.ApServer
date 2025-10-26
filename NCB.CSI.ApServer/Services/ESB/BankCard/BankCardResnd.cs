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
    ///  卡片補換發
    /// </summary>
    [EsbTxnId("BC02")]
    public class BankCardResnd : EsbService<BankCardResndRq, BankCardResndRs> {
        public override async Task<(BankCardResndRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardResndRq model) => EsbResult(await PostAsync(model));
    }
}