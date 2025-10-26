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
    /// 卡片最新資料
    /// </summary>
    [EsbTxnId("BC01")]
    public class BankCardSummInq : EsbService<BankCardSummInqRq, BankCardSummInqRs> {
        public override async Task<(BankCardSummInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardSummInqRq model) => EsbResult(await PostAsync(model));
    }
}