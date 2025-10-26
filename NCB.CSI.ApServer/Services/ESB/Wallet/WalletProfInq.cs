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
    ///  查詢一卡通基本資料
    /// </summary>
    [EsbTxnId("WA01")]
    public class WalletProfInq : EsbService<WalletProfInqRq, WalletProfInqRs> {
        public override async Task<(WalletProfInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(WalletProfInqRq model) => EsbResult(await PostAsync(model));
    }
}