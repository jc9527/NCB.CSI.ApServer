using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.OTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.OTP {
    public class svSend_SMS : OtpService<svSend_SMSRq, svSend_SMSRs> {
        public override async Task<(svSend_SMSRs Result, string ResultCode, string ResultMessage)>
            RunAsync(svSend_SMSRq model) => OtpResult(await PostAsync(Convert(model)));
    }
}