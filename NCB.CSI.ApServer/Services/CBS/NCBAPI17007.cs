using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.CBS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.CBS {
    public class NCBAPI17007 : CbsService<NCBAPI17007Rq, NCBAPI17007Rs> {
        public override async Task<(NCBAPI17007Rs Result, string ResultCode, string ResultMessage)>
            RunAsync(NCBAPI17007Rq model) => CbsResult(await PostAsync(model));
    }
}