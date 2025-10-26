using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DebitCard {
    /// <summary>
    ///  卡片帳務費用查詢
    /// </summary>
    [EsbTxnId("DC28")]
    public class DbCardFeeInq : EsbService<DbCardFeeInqRq, DbCardFeeInqRs> {
        public override async Task<(DbCardFeeInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardFeeInqRq model) => EsbResult(await PostAsync(model));
    }

}