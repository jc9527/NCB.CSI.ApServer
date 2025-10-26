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
    ///  卡片補換發檢核
    /// </summary>
    [EsbTxnId("BC08")]
    public class BankCardResndChk : EsbService<BankCardResndChkRq, BankCardResndChkRs> {
        public override async Task<(BankCardResndChkRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardResndChkRq model) => EsbResult(await PostAsync(model));
    }
}