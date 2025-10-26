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
    ///  查詢第三方總點數
    /// </summary>
    [EsbTxnId("RP09")]
    public class VndrRwdPntsInq : EsbService<VndrRwdPntsInqRq, VndrRwdPntsInqRs>
    {
        public override async Task<(VndrRwdPntsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(VndrRwdPntsInqRq model) => EsbResult(await PostAsync(model));
    }
}