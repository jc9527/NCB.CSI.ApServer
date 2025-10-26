using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.OTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.OTP {
    public class svDeRegister : OtpService<svDeRegisterRq, svDeRegisterRs> {
        public override async Task<(svDeRegisterRs Result, string ResultCode, string ResultMessage)>
            RunAsync(svDeRegisterRq model) => OtpResult(await PostAsync(Convert(model)));
    }
}