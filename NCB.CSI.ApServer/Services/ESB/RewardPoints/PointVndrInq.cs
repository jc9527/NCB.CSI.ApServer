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
    ///  供應商管理-列表
    /// </summary>
    [EsbTxnId("RP14")]
    public class PointVndrInq : EsbService<PointVndrInqRq, PointVndrInqRs>
    {
        public override async Task<(PointVndrInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PointVndrInqRq model) => EsbResult(await PostAsync(model));
    }
}