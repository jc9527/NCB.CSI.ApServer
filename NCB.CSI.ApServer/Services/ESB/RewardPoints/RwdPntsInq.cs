using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.RewardPoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.RewardPoints
{
    /// <summary>
    ///  點數餘額查詢
    /// </summary>
    [EsbTxnId("RP01")]
    public class RwdPntsInq : EsbService<RwdPntsInqRq, RwdPntsInqRs>
    {
        public override async Task<(RwdPntsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(RwdPntsInqRq model) => EsbResult(await PostAsync(model));
    }
}