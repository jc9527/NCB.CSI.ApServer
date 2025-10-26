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
    ///  換補發歷史紀錄查詢
    /// </summary>
    [EsbTxnId("BC11")]
    public class BankCardResndHistInq : EsbService<BankCardResndHistInqRq, BankCardResndHistInqRs>
    {
        public override async Task<(BankCardResndHistInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardResndHistInqRq model) => EsbResult(await PostAsync(model));
    }
}