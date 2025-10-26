using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.CustomerTax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.CustomerTax {
    /// <summary>
    ///  補扣差息
    /// </summary>
    [EsbTxnId("CT05")]
    public class DbAdjIntrstAdd : EsbService<DbAdjIntrstAddRq, DbAdjIntrstAddRs> {
        public override async Task<(DbAdjIntrstAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DbAdjIntrstAddRq model) => EsbResult(await PostAsync(model));
    }
}