using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.AbstractServices;
using NCB.CSI.Models.BMS;

namespace NCB.CSI.ApServer.AbstractServices {
    public abstract class BmsService<TReqModel, TRespModel> : HttpService<TReqModel, TRespModel> where TRespModel : BmsCommonRs {
        private string Version { get; }
        public BmsService(string version = "v1.0", string configKey = "BMS.BaseAddress") : base(ConfigurationManager.AppSettings[configKey]) {
            Connector.Headers.Add(new KeyValuePair<string, string>("X-NCB-Channel", "OPT"));
            Version = version;
        }
        protected Task<TRespModel> PostAsync(TReqModel model) => Connector.PostAsJsonAsync<TRespModel>($"{Version}/{ServiceNamespace}/{ServiceName}", model);
        protected (TRespModel Result, string ResultCode, string ResultMessage) BmsResult(TRespModel result) =>
            result.success ? SuccessResult(result) : (result, result.error.errorCode, result.error.errorMessage);
    }
}