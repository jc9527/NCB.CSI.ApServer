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
    ///  卡片續卡設定
    /// </summary>
    [EsbTxnId("DC18")]
    public class DbCardResndAppntAdd : EsbService<DbCardResndAppntAddRq, DbCardResndAppntAddRs> {
        public override async Task<(DbCardResndAppntAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardResndAppntAddRq model) => EsbResult(await PostAsync(model));
    }
}