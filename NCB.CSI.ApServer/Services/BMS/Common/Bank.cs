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
    /// 全國銀行列表
    /// </summary>
    [ServiceNamespace("common")]
    [ServiceName("bank")]
    public class Bank : BmsService<BankRq, BankRs> {
        public Bank() : base("v1.0", "BMS.BaseAddress3") { }
        public override async Task<(BankRs Result, string ResultCode, string ResultMessage)>
            RunAsync(BankRq model) => BmsResult(await PostAsync(model));
    }
}