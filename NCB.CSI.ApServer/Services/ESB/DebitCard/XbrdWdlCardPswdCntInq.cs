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
    ///  卡片國外提領預借現金密碼錯誤次數查詢
    /// </summary>
    [EsbTxnId("DC23")]
    public class XbrdWdlCardPswdCntInq : EsbService<XbrdWdlCardPswdCntInqRq, XbrdWdlCardPswdCntInqRs> {
        public override async Task<(XbrdWdlCardPswdCntInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(XbrdWdlCardPswdCntInqRq model) => EsbResult(await PostAsync(model));
    }
}