using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.BMS.Loan {
    /// <summary>
    /// 貸款補傳送email契據
    /// </summary>
    [ServiceNamespace("loan")]
    public class SendForEmail : BmsService<SendForEmailRq, SendForEmailRs> {
        public override async Task<(SendForEmailRs Result, string ResultCode, string ResultMessage)>
            RunAsync(SendForEmailRq model) => BmsResult(await PostAsync(model));
    }
}