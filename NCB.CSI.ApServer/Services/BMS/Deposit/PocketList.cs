using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Deposit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.BMS.Deposit {
    /// <summary>
    /// 客作服 - 取得客戶帳戶列表
    /// </summary>
    [ServiceNamespace("deposit")]
    public class PocketList : BmsService<PocketListRq, PocketListRs> {
        public override async Task<(PocketListRs Result, string ResultCode, string ResultMessage)>
            RunAsync(PocketListRq model) => BmsResult(await PostAsync(model));
    }
}