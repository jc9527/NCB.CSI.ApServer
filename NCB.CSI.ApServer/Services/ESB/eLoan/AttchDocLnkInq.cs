using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.eLoan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.eLoan {
    /// <summary>
    ///  取得傳送補件連結
    /// </summary>
    [EsbTxnId("EL29")]
    public class AttchDocLnkInq : EsbService<AttchDocLnkInqRq, AttchDocLnkInqRs>
    {
        public override async Task<(AttchDocLnkInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AttchDocLnkInqRq model) => EsbResult(await PostAsync(model));
    }
}