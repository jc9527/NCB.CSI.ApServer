using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.DebitCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.DebitCard {
    /// <summary>
    ///  VD卡客戶基本資料查詢
    /// </summary>
    [EsbTxnId("DC12")]
    public class CardCIFInfoInq : EsbService<CardCIFInfoInqRq, CardCIFInfoInqRs> {
        public override async Task<(CardCIFInfoInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(CardCIFInfoInqRq model) => EsbResult(await PostAsync(model));
    }
}