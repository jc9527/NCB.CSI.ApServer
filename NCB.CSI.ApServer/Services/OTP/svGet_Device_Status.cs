using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.OTP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.OTP {
    public class svGet_Device_Status : OtpService<svGet_Device_StatusRq, svGet_Device_StatusRs> {
        public override async Task<(svGet_Device_StatusRs Result, string ResultCode, string ResultMessage)>
            RunAsync(svGet_Device_StatusRq model) => OtpResult(await PostAsync(Convert(model)));
    }
}