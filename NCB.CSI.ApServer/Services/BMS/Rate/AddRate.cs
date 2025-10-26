using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Rate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Services.BMS.Rate {
    /// <summary>
    /// 新增牌告利率
    /// </summary>
    [ServiceNamespace("rate")]
    public class AddRate : BmsService<AddRateRq, AddRateRs> {
        public override async Task<(AddRateRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AddRateRq model) => BmsResult(await PostAsync(model));
    }
}