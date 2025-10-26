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
    /// 客服-查詢會員數位等級的驗證狀態和升級時間
    /// </summary>
    [ServiceNamespace("member")]
    public class GetAccountUpgrade : BmsService<GetAccountUpgradeRq, GetAccountUpgradeRs> {
        public override async Task<(GetAccountUpgradeRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetAccountUpgradeRq model) => BmsResult(await PostAsync(model));
    }
}