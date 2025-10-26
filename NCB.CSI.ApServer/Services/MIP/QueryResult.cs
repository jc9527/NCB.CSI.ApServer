using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.MIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace NCB.CSI.ApServer.Services.MIP {
    public class QueryResult : MipService<QueryResultRq, QueryResultRs> {
        private (QueryResultRs Result, string ResultCode, string ResultMessage) Result(QueryResultRs result) =>
            result.status == "0" ? SuccessResult(result) : (result, result.status, result.result_msg);

        public override async Task<(QueryResultRs Result, string ResultCode, string ResultMessage)>
            RunAsync(QueryResultRq model) => Result(await PostAsync(model));
    }
}