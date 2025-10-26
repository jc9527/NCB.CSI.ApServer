using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DepositAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DepositAccount
{
    /// <summary>
    ///  約定轉帳個人額度調整歷史查詢
    /// </summary>
    [EsbTxnId("DA18")]
    public class PreDsgntdLmtHisInq : EsbService<PreDsgntdLmtHisInqRq, PreDsgntdLmtHisInqRs>
    {
        public override async Task<(PreDsgntdLmtHisInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PreDsgntdLmtHisInqRq model) => EsbResult(await PostAsync(model));
    }
}