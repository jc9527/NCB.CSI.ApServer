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
    ///  活動類別管理-列表
    /// </summary>
    [EsbTxnId("RP16")]
    public class PointCampGrpInq : EsbService<PointCampGrpInqRq, PointCampGrpInqRs>
    {
        public override async Task<(PointCampGrpInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PointCampGrpInqRq model) => EsbResult(await PostAsync(model));
    }
}