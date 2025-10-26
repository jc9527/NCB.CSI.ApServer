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
    ///  查詢客戶點數歷程 (照交易時間遞減排序)
    /// </summary>
    [EsbTxnId("PR05")]
    public class RwdPntsHistInq : EsbService<RwdPntsHistInqRq, RwdPntsHistInqRs>
    {
        public override async Task<(RwdPntsHistInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(RwdPntsHistInqRq model) => EsbResult(await PostAsync(model));
    }
}