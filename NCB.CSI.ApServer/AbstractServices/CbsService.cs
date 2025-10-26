using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.AbstractServices;
using NCB.CSI.Models.CBS;

namespace NCB.CSI.ApServer.AbstractServices {
    public abstract class CbsService<TReqModel, TRespModel> : HttpService<TReqModel, TRespModel> where TRespModel : CbsCommonRs {
        public CbsService() : base(ConfigurationManager.AppSettings["CBS.BaseAddress"]) { }
        private string ToQueryString(TReqModel model) => string.Join("&", model.GetType().GetProperties().Select(x => $"{x.Name}={x.GetValue(model)}"));
        protected Task<TRespModel> PostAsync(TReqModel model) => Connector.GetAsync<TRespModel>($"{ServiceName}/?{ToQueryString(model)}");
        protected (TRespModel Result, string ResultCode, string ResultMessage) CbsResult(TRespModel result) =>
            result.error == null ? SuccessResult(result) : (result, result.error.code, result.error.message);
    }
}