using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.CurrentAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.CurrentAccount {
    /// <summary>
    /// 加息券利率條件調整
    /// </summary>
    [EsbTxnId("CA06")]
    public class CampIntrstRateMod : EsbService<CampIntrstRateModRq, CampIntrstRateModRs> {
        public override async Task<(CampIntrstRateModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CampIntrstRateModRq model) => EsbResult(await PostAsync(model));
    }
}