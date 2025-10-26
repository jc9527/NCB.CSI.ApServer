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
    ///  卡片帳務費用新增
    /// </summary>
    [EsbTxnId("DC25")]
    public class DbCardFeeAdd : EsbService<DbCardFeeAddRq, DbCardFeeAddRs> {
        public override async Task<(DbCardFeeAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardFeeAddRq model) => EsbResult(await PostAsync(model));
    }
}