using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.DebitCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.ApServer.Services.BMS.DebitCards {
    /// <summary>
    /// 作服 - 更新客戶修改寄送地址狀態
    /// </summary>
    [ServiceNamespace("debitcards")]
    public class UpdateCheckAddrStatus : BmsService<UpdateCheckAddrStatusRq, UpdateCheckAddrStatusRs> {
        public UpdateCheckAddrStatus() : base("v1.1") { }
        public override async Task<(UpdateCheckAddrStatusRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UpdateCheckAddrStatusRq model) => BmsResult(await PostAsync(model));
    }
}
