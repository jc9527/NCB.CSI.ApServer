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
    public class DeleteFile : CmService<DeleteFileRq, DeleteFileRs> {
        public override async Task<(DeleteFileRs Result, string ResultCode, string ResultMessage)>
            RunAsync(DeleteFileRq model) => CmResult(await PostAsync(model));
    }
}