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
    /// 作服 - 修改行職業
    /// </summary>
    [ServiceNamespace("createaccount")]
    public class ModifyIndustryAndJob : BmsService<ModifyIndustryAndJobRq, ModifyIndustryAndJobRs> {
        public override async Task<(ModifyIndustryAndJobRs Result, string ResultCode, string ResultMessage)>
            RunAsync(ModifyIndustryAndJobRq model) => BmsResult(await PostAsync(model));
    }
}