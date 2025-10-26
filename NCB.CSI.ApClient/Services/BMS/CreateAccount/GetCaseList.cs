using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.Net.AbstractServices;
using Devpro.Shared.Attributies;
using NCB.CSI.Models.BMS.CreateAccount;

namespace NCB.CSI.ApClient.Services.BMS.CreateAccount {
    /// <summary>
    /// 依狀態,時間區間抓取開戶進件案
    /// </summary>
    [ServiceNamespace("Privilege/BMS/CreateAccount")]
    public class GetCaseList : ApClientBaseService<GetCaseListRq, GetCaseListRs> {
        public override Task<(GetCaseListRs Result, string ResultCode, string ResultMessage)> RunAsync(GetCaseListRq model) => PostAsync(model);
    }
}