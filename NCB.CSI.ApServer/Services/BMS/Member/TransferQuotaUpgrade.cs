using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Services.BMS.Member {
    /// <summary>
    /// 客服-升級數3A+
    /// </summary>
    [ServiceNamespace("member")]
    public class TransferQuotaUpgrade : BmsService<TransferQuotaUpgradeRq, TransferQuotaUpgradeRs> {
        public override async Task<(TransferQuotaUpgradeRs Result, string ResultCode, string ResultMessage)>
            RunAsync(TransferQuotaUpgradeRq model) => BmsResult(await PostAsync(model));
    }
}