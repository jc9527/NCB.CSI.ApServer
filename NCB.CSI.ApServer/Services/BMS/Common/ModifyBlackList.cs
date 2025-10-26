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
    /// 作服 - 修改行內黑名單API
    /// </summary>
    [ServiceNamespace("common")]
    public class ModifyBlackList : BmsService<ModifyBlackListRq, ModifyBlackListRs> {
        public override async Task<(ModifyBlackListRs Result, string ResultCode, string ResultMessage)>
            RunAsync(ModifyBlackListRq model) => BmsResult(await PostAsync(model));
    }
}