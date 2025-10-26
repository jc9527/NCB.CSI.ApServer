using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB;
using NCB.CSI.Models.ESB.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DebitCard {
    /// <summary>
    /// 簽帳卡交易明細查詢
    /// </summary>
    [EsbTxnId("DC01")]
    public class DbCardTxnDtlsInq : EsbService<DbCardTxnDtlsInqRq, DbCardTxnDtlsInqRs> {
        public override async Task<(DbCardTxnDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardTxnDtlsInqRq model) => EsbResult(await PostAsync(model));
    }
}