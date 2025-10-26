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
    /// 查詢牌告利率
    /// </summary>
    [ServiceNamespace("rate")]
    public class GetRates : BmsService<GetRatesRq, GetRatesRs> {
        public override async Task<(GetRatesRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetRatesRq model) => BmsResult(await PostAsync(model));
    }
}