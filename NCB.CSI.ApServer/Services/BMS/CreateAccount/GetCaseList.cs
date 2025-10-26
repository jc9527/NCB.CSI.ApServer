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
    /// 依狀態,時間區間抓取開戶進件案
    /// </summary>
    [ServiceNamespace("createaccount")]
    public class GetCaseList : BmsService<GetCaseListRq, GetCaseListRs> {
        public GetCaseList() : base("v2.0") { }
        public override async Task<(GetCaseListRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetCaseListRq model) => BmsResult(await PostAsync(model));
    }
}