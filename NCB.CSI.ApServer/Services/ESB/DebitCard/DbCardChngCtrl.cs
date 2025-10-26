using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DebitCard {
    /// <summary>
    ///  簽帳卡更改管制
    /// </summary>
    [EsbTxnId("DC03")]
    public class DbCardChngCtrl : EsbService<DbCardChngCtrlRq, DbCardChngCtrlRs> {
        public override async Task<(DbCardChngCtrlRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbCardChngCtrlRq model) => EsbResult(await PostAsync(model));
    }

}