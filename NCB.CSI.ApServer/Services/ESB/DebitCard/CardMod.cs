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
    ///  卡況異動
    /// </summary>
    [EsbTxnId("DC09")]
    public class CardMod : EsbService<CardModRq, CardModRs> {
        public override async Task<(CardModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CardModRq model) => EsbResult(await PostAsync(model));
    }

}