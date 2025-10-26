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
    /// 依身分證字號取得貸款案件
    /// </summary>
    [ServiceNamespace("loan")]
    public class GetLoanInfoById : BmsService<GetLoanInfoByIdRq, GetLoanInfoRs> {
        public override async Task<(GetLoanInfoRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetLoanInfoByIdRq model) => BmsResult(await PostAsync(model));
    }
}