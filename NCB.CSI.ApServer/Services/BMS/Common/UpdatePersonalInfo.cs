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
    /// 作服 - 修改個人資訊(姓名、戶籍地址)
    /// </summary>
    [ServiceNamespace("common")]
    public class UpdatePersonalInfo : BmsService<UpdatePersonalInfoRq, UpdatePersonalInfoRs> {
        public UpdatePersonalInfo() : base("v2.0") { }
        public override async Task<(UpdatePersonalInfoRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UpdatePersonalInfoRq model) => BmsResult(await PostAsync(model));
    }
}