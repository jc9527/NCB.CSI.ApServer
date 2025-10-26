using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Devpro.Models;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.CM;

namespace NCB.CSI.ApServer.Services.CM {
    public class GetFile : CmService<GetFileRq, GetFileRs> {
        public override async Task<(GetFileRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetFileRq model) => CmResult(await PostAsync(model));
    }
}