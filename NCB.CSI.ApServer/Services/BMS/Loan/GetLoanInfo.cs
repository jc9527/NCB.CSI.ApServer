using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.BMS.Loan {
    /// <summary>
    /// 查詢貸款進件
    /// </summary>
    [ServiceNamespace("loan")]
    public class GetLoanInfo : BmsService<GetLoanInfoRq, GetLoanInfoRs> {
        public override async Task<(GetLoanInfoRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetLoanInfoRq model) => BmsResult(await PostAsync(model));
    }
}