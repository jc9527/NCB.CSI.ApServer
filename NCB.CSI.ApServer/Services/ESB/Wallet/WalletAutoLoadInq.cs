using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.Wallet {
    /// <summary>
    ///  自動加值資料查詢
    /// </summary>
    [EsbTxnId("WA03")]
    public class WalletAutoLoadInq : EsbService<WalletAutoLoadInqRq, WalletAutoLoadInqRs> {
        public override async Task<(WalletAutoLoadInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(WalletAutoLoadInqRq model) => EsbResult(await PostAsync(model));
    }
}