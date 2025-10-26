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
    /// 依開戶進件號碼回寫審核結果, 包含被要求補件;審核通過;婉拒 + 原因
    /// </summary>
    [ServiceNamespace("createaccount")]
    public class UpdateStatus : BmsService<UpdateStatusRq, UpdateStatusRs> {
        public override async Task<(UpdateStatusRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UpdateStatusRq model) => BmsResult(await PostAsync(model));
    }
}