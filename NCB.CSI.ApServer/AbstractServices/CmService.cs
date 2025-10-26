using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.AbstractServices;
using NCB.CSI.Models.CM;

namespace NCB.CSI.ApServer.AbstractServices {
    public abstract class CmService<TReqModel, TRespModel> : HttpService<TReqModel, TRespModel> where TRespModel : CmCommonRs {
        public CmService() : base(ConfigurationManager.AppSettings["CM.BaseAddress"]) { }
        protected Task<TRespModel> PostAsync(TReqModel model) => Connector.PostAsJsonAsync<TRespModel>($"{ServiceName}/Post", model);
        protected (TRespModel Result, string ResultCode, string ResultMessage) CmResult(TRespModel result) =>
            result.Success ? SuccessResult(result) : (result, result.Code.ToString(), result.Describe);
    }
}