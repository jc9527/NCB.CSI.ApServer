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
    ///  卡片事故申請
    /// </summary>
    [EsbTxnId("BC03")]
    public class BankCardRgstr : EsbService<BankCardRgstrRq, BankCardRgstrRs> {
        public override async Task<(BankCardRgstrRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardRgstrRq model) => EsbResult(await PostAsync(model));
    }
}