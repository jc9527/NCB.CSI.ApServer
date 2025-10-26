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
    ///  卡片新申請
    /// </summary>
    [EsbTxnId("BC06")]
    public class BankCardApp : EsbService<BankCardAppRq, BankCardAppRs> {
        public override async Task<(BankCardAppRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardAppRq model) => EsbResult(await PostAsync(model));
    }
}