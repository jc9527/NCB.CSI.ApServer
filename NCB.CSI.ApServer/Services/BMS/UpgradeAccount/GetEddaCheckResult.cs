using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.UpgradeAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Services.BMS.UpgradeAccount {
    /// <summary>
    /// 查詢自然人憑證驗證結果
    /// </summary>
    [ServiceNamespace("upgradeaccount")]
    public class GetEddaCheckResult : BmsService<GetEddaCheckResultRq, GetEddaCheckResultRs> {
        public override async Task<(GetEddaCheckResultRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetEddaCheckResultRq model) => BmsResult(await PostAsync(model));
    }
}