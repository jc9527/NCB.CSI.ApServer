using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.Payment {
    /// <summary>
    ///  卡片線上解圈查詢
    /// </summary>
    [EsbTxnId("PA03")]
    public class UnlockInq : EsbService<UnlockInqRq, UnlockInqRs> {
        public override async Task<(UnlockInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UnlockInqRq model) => EsbResult(await PostAsync(model));
    }
}