using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Common;

namespace NCB.CSI.ApServer.Services.BMS.Common {
    /// <summary>
    /// 作服 - 撈取行內黑名單API
    /// </summary>
    [ServiceNamespace("common")]
    public class GetBlackList : BmsService<GetBlackListRq, GetBlackListRs> {
        public override async Task<(GetBlackListRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetBlackListRq model) => BmsResult(await PostAsync(model));
    }
}