using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.OTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.OTP {
    public class svVerify_SMS : OtpService<svVerify_SMSRq, svVerify_SMSRs> {
        public override async Task<(svVerify_SMSRs Result, string ResultCode, string ResultMessage)>
            RunAsync(svVerify_SMSRq model) => OtpResult(await PostAsync(Convert(model)));
    }
}