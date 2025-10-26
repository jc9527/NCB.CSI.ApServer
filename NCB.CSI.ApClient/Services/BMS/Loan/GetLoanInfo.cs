using Devpro.Connectors.Net.AbstractServices;
using Devpro.Shared.Attributies;
using NCB.CSI.Models.BMS.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApClient.Services.BMS.Loan {
    /// <summary>
    /// 查詢貸款進件
    /// </summary>
    [ServiceNamespace("Privilege/BMS/Loan")]
    public class GetLoanInfo : ApClientBaseService<GetLoanInfoRq, GetLoanInfoRs> {
        public override async Task<(GetLoanInfoRs Result, string ResultCode, string ResultMessage)> RunAsync(GetLoanInfoRq model) => await PostAsync(model);
    }
}