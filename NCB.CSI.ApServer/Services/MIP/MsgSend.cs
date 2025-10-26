using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.MIP;

namespace NCB.CSI.ApServer.Services.MIP {
    public class MsgSend : MipService<MsgSendRq, MsgSendRs> {
        private (MsgSendRs Result, string ResultCode, string ResultMessage) Result(MsgSendRs result) =>
            result.result == "1" ? SuccessResult(result) : (result, result.result, result.result_msg);

        public override async Task<(MsgSendRs Result, string ResultCode, string ResultMessage)>
            RunAsync(MsgSendRq model) => Result(await PostAsync(model));
    }
}