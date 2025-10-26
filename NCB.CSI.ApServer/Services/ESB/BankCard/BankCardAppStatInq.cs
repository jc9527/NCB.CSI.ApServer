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
    /// 卡片資料查詢
    /// </summary>
    [EsbTxnId("BC07")]
    public class BankCardAppStatInq : EsbService<BankCardAppStatInqRq, BankCardAppStatInqRs> {
        public override async Task<(BankCardAppStatInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardAppStatInqRq model) => EsbResult(await PostAsync(model));
    }
}