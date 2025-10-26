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
    /// 作服 - 新增行內黑名單API
    /// </summary>
    [ServiceNamespace("common")]
    public class CreateBlackList : BmsService<CreateBlackListRq, CreateBlackListRs> {
        public override async Task<(CreateBlackListRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CreateBlackListRq model) => BmsResult(await PostAsync(model));
    }
}