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
    ///  查詢補件內容
    /// </summary>
    [EsbTxnId("EL28")]
    public class AttchDocListInq : EsbService<AttchDocListInqRq, AttchDocListInqRs> {
        public override async Task<(AttchDocListInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AttchDocListInqRq model) => EsbResult(await PostAsync(model));
    }
}