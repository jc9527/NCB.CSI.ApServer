using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB;
using NCB.CSI.Models.ESB.DepositAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DepositAccount
{
    /// <summary>
    ///  帳戶交易明細查詢
    /// </summary>
    [EsbTxnId("DA02")]
    public class AcctTxnDtlsInq : EsbService<AcctTxnDtlsInqRq, AcctTxnDtlsInqRs>
    {
        public override async Task<(AcctTxnDtlsInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcctTxnDtlsInqRq model) => EsbResult(await PostAsync(model));
    }

}