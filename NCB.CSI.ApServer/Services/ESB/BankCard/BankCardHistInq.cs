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
    ///  歷史卡況查詢
    /// </summary>
    [EsbTxnId("BC05")]
    public class BankCardHistInq : EsbService<BankCardHistInqRq, BankCardHistInqRs> {
        public override async Task<(BankCardHistInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardHistInqRq model) => EsbResult(await PostAsync(model));
    }
}