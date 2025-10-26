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
    ///  卡片事故紀錄查詢
    /// </summary>
    [EsbTxnId("BC09")]
    public class BankCardAcidntInq : EsbService<BankCardAcidntInqRq, BankCardAcidntInqRs> {
        public override async Task<(BankCardAcidntInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankCardAcidntInqRq model) => EsbResult(await PostAsync(model));
    }
}