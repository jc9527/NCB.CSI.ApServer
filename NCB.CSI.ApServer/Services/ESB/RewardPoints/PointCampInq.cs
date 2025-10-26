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
    ///  活動管理-列表
    /// </summary>
    [EsbTxnId("RP12")]
    public class PointCampInq : EsbService<PointCampInqRq, PointCampInqRs>
    {
        public override async Task<(PointCampInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PointCampInqRq model) => EsbResult(await PostAsync(model));
    }
}