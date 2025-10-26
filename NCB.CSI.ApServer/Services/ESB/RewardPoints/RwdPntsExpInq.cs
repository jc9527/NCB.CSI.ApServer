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
    ///  查詢客戶即將到期點數
    /// </summary>
    [EsbTxnId("PR06")]
    public class RwdPntsExpInq : EsbService<RwdPntsExpInqRq, RwdPntsExpInqRs>
    {
        public override async Task<(RwdPntsExpInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(RwdPntsExpInqRq model) => EsbResult(await PostAsync(model));
    }
}