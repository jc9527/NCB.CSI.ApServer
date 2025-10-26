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
    ///  查詢客戶黑名單狀態
    /// </summary>
    [EsbTxnId("PR07")]
    public class RwdPntsCustStatInq : EsbService<RwdPntsCustStatInqRq, RwdPntsCustStatInqRs>
    {
        public override async Task<(RwdPntsCustStatInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(RwdPntsCustStatInqRq model) => EsbResult(await PostAsync(model));
    }
}