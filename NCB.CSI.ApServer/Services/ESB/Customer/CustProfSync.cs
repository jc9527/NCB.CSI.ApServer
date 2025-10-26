using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.Customer;

namespace NCB.CSI.ApServer.Services.ESB.Customer {
    /// <summary>
    /// 同步異動CIF資料
    /// </summary>
    [EsbTxnId("CU20")]
    public class CustProfSync : EsbService<CustProfSyncRq, CustProfSyncRs> {
        public override async Task<(CustProfSyncRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CustProfSyncRq model) => EsbResult(await PostAsync(model));
    }
}