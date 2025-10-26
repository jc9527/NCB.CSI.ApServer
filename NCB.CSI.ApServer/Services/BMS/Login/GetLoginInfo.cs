using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.BMS.Login {
    /// <summary>
    /// 查詢會員的登入與登出紀錄
    /// </summary>
    [ServiceNamespace("login")]
    public class GetLoginInfo : BmsService<GetLoginInfoRq, GetLoginInfoRs> {
        public override async Task<(GetLoginInfoRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetLoginInfoRq model) => BmsResult(await PostAsync(model));
    }
}