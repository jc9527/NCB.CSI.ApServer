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
    /// AllInOne客戶及帳戶資料查詢
    /// </summary>
    [EsbTxnId("CU17")]
    public class CustSummInq : EsbService<CustSummInqRq, CustSummInqRs> {
        public override async Task<(CustSummInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CustSummInqRq model) => EsbResult(await PostAsync(model));
    }
}