using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.AbstractServices;
using NCB.CSI.Models.OTP;

namespace NCB.CSI.ApServer.AbstractServices {
    public abstract class OtpService<TReqModel, TRespModel> : HttpService<TReqModel, TRespModel> where TRespModel : OtpCommonRs {
        public OtpService() : base(ConfigurationManager.AppSettings["OTP.BaseAddress"]) { }
        protected Task<TRespModel> PostAsync(IEnumerable<KeyValuePair<string, string>> formData) {
            Connector.Accept = "application/json";
            Connector.Headers.Add(new KeyValuePair<string, string>("apiKey", ConfigurationManager.AppSettings["OTP.ApiKey"]));
            return Connector.FormPostAsync<TRespModel>("", formData.Concat(new[] { new KeyValuePair<string, string>("method", ServiceName) }));
        }
        protected (TRespModel Result, string ResultCode, string ResultMessage) OtpResult(TRespModel result) =>
            result.success ? SuccessResult(result) : (result, result.returnCode, result.returnMsg);
        protected IEnumerable<KeyValuePair<string, string>> Convert(object model) => 
            model.GetType().GetProperties().Select(x => new KeyValuePair<string, string>(x.Name, x.GetValue(model)?.ToString()));
    }
}