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
    /// 優惠利率到期(取消)
    /// </summary>
    [EsbTxnId("CA07")]
    public class CampIntrstRateCan : EsbService<CampIntrstRateCanRq, CampIntrstRateCanRs> {
        public override async Task<(CampIntrstRateCanRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CampIntrstRateCanRq model) => EsbResult(await PostAsync(model));
    }
}