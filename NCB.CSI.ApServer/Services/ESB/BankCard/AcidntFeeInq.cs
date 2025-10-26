using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB.BankCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.ESB.BankCard {
    /// <summary>
    ///  是否收事故費用查詢
    /// </summary>
    [EsbTxnId("BC12")]
    public class AcidntFeeInq : EsbService<AcidntFeeInqRq, AcidntFeeInqRs> {
        public override async Task<(AcidntFeeInqRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AcidntFeeInqRq model) => EsbResult(await PostAsync(model));
    }
}