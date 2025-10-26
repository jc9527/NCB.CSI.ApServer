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
    public class UploadFile : CmService<UploadFileRq, UploadFileRs> {
        public override async Task<(UploadFileRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UploadFileRq model) => CmResult(await PostAsync(model));
    }
}