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
    /// 作服 - 查詢客戶修改寄送地址紀錄
    /// </summary>
    [ServiceNamespace("debitcards")]
    public class GetCheckAddrList : BmsService<GetCheckAddrListRq, GetCheckAddrListRs> {
        public GetCheckAddrList() : base("v1.1") { }
        public override async Task<(GetCheckAddrListRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetCheckAddrListRq model) => BmsResult(await PostAsync(model));
    }
}
