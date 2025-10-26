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
    ///  卡片啟用
    /// </summary>
    [EsbTxnId("BC04")]
    public class BankCardOpen : EsbService<BankCardOpenRq, BankCardOpenRs> {
        public override async Task<(BankCardOpenRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardOpenRq model) => EsbResult(await PostAsync(model));
    }
}