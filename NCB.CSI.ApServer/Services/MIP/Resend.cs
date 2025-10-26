using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.MIP;

namespace NCB.CSI.ApServer.Services.MIP {
    public class Resend : MipService<ResendRq, ResendRs> {
        private (ResendRs Result, string ResultCode, string ResultMessage) Result(ResendRs result) =>
            result.statuscode == "0" ? SuccessResult(result) : (result, result.statuscode, result.statuscodemsg);

        public override async Task<(ResendRs Result, string ResultCode, string ResultMessage)>
            RunAsync(ResendRq model) => Result(await PostAsync(model));
    }
}