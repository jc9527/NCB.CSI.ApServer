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
    ///  CIF(個人戶)完整建檔
    /// </summary>
    [EsbTxnId("CU03")]
    public class CustProfAdd : EsbService<CustProfAddRq, CustProfAddRs> {
        public override async Task<(CustProfAddRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CustProfAddRq model) => EsbResult(await PostAsync(model));
    }
}