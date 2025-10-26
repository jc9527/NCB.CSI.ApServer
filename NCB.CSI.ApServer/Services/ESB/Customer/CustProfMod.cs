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
    /// CIF(個人戶)維護
    /// </summary>
    [EsbTxnId("CU09")]
    public class CustProfMod : EsbService<CustProfModRq, CustProfModRs> {
        public override async Task<(CustProfModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CustProfModRq model) => EsbResult(await PostAsync(model));
    }
}