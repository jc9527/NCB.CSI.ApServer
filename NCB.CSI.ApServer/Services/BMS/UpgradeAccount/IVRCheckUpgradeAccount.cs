using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.UpgradeAccount;

namespace NCB.CSI.ApServer.Services.BMS.UpgradeAccount {
    /// <summary>
    /// 客服呼叫數位帳戶升級(客服視訊帳戶升級完成)
    /// </summary>
    [ServiceNamespace("upgradeaccount")]
    public class IVRCheckUpgradeAccount : BmsService<IVRCheckUpgradeAccountRq, IVRCheckUpgradeAccountRs> {
        public override async Task<(IVRCheckUpgradeAccountRs Result, string ResultCode, string ResultMessage)>
            RunAsync(IVRCheckUpgradeAccountRq model) => BmsResult(await PostAsync(model));
    }
}