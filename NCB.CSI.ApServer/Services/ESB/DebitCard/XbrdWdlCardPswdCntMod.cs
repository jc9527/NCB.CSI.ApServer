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
    ///  卡片國外提領預借現金密碼錯誤次數歸零
    /// </summary>
    [EsbTxnId("DC24")]
    public class XbrdWdlCardPswdCntMod : EsbService<XbrdWdlCardPswdCntModRq, XbrdWdlCardPswdCntModRs> {
        public override async Task<(XbrdWdlCardPswdCntModRs Result, string ResultCode, string ResultMessage)>
            RunAsync(XbrdWdlCardPswdCntModRq model) => EsbResult(await PostAsync(model));
    }
}