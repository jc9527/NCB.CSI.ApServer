using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.Customer {
    /// <summary>
    ///  CIF層事故歷史查詢
    /// </summary>
    [EsbTxnId("CU07")]
    public class CIFRstrctHistInq : EsbService<CIFRstrctHistInqRq, CIFRstrctHistInqRs> {
        public override async Task<(CIFRstrctHistInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CIFRstrctHistInqRq model) => EsbResult(await PostAsync(model));
    }

}