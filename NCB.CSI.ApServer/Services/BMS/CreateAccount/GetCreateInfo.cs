using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.CreateAccount;

namespace NCB.CSI.ApServer.Services.BMS.CreateAccount {
    /// <summary>
    /// 客服-查詢開戶進件
    /// </summary>
    [ServiceNamespace("createaccount")]
    public class GetCreateInfo : BmsService<GetCreateInfoRq, GetCreateInfoRs> {
        public override async Task<(GetCreateInfoRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetCreateInfoRq model) => BmsResult(await PostAsync(model));
    }
}