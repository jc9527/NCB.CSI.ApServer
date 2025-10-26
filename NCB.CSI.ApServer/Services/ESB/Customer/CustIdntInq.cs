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
    /// Email(手機)查詢
    /// </summary>
    [EsbTxnId("CU18")]
    public class CustIdntInq : EsbService<CustIdntInqRq, CustIdntInqRs> {
        public override async Task<(CustIdntInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CustIdntInqRq model) => EsbResult(await PostAsync(model));
    }
}