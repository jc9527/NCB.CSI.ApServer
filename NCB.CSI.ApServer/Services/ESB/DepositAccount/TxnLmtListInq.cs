using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DepositAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DepositAccount {
    /// <summary>
    ///  交易限額查詢
    /// </summary>
    [EsbTxnId("DA34")]
    public class TxnLmtListInq : EsbService<TxnLmtListInqRq, TxnLmtListInqRs> {
        public override async Task<(TxnLmtListInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TxnLmtListInqRq model) => EsbResult(await PostAsync(model));
    }
}