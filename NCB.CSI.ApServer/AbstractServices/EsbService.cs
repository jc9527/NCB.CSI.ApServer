using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.AbstractServices;
using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using NCB.CSI.ApServer.Shared.Attributes;
using NCB.CSI.Models.ESB;
using Newtonsoft.Json;

namespace NCB.CSI.ApServer.AbstractServices {
    public abstract class EsbService<TReqModel, TRespModel> : HttpService<TReqModel, TRespModel> where TRespModel : IEsbCommonRs {
        public EsbService() : base(ConfigurationManager.AppSettings["ESB.BaseAddress"]) => Connector.Accept = "text/plain";

        protected (TRespModel Result, string ResultCode, string ResultMessage) EsbResult(TRespModel result) =>
            result.Success ? SuccessResult(result) : (result, result.Fault?.Code?.Value ?? result.RtrnStatCode.RtrnCode, result.Fault?.Reason?.Text ?? result.RtrnStatCode.RtrnDesc);

        private T ConvertTo<T>(object o) {
            var content = JsonConvert.SerializeObject(o);
            try {
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (JsonException e) {
                throw new JsonExceptionEx(e, content);
            }
        }

        protected async Task<TRespModel> PostAsync(EsbRqServiceBody model) {
            var request = new EsbRequest {
                amheader = new EsbAmHeader {
                    ChannelID = ConfigurationManager.AppSettings["ESB.ChannelID"],
                    ServiceDomain = ServiceNamespace,
                    OperationName = ServiceName,
                    ConsumerID = ConfigurationManager.AppSettings["ESB.ConsumerID"],
                    TransactionID = Guid.NewGuid().ToString("N"),
                    RqTimestamp = DateTime.Now
                },
                ambody = new Dictionary<string, EsbServiceRq> { { $"{ServiceName}Rq", new EsbServiceRq {
                    ServiceHeader = new EsbServiceHeader {
                        TxnId = GetType().GetCustomAttribute<EsbTxnIdAttribute>(false)?.TxnId,
                        TxnNo = Guid.NewGuid().ToString("N")
                    },
                    Signon = new EsbSignon {
                        CustId = ConfigurationManager.AppSettings["ESB.CustId"],
                        //CustPswd = "123456"
                    },
                    ServiceBody = model
                } } }
            };
            var response = await Connector.PostAsJsonAsync<IDictionary<string, dynamic>>("apicommon", request);
            if (response["ambody"]["Fault"] != null) {
                return ConvertTo<TRespModel>(response["ambody"]);
            }
            return ConvertTo<TRespModel>(response["ambody"][$"{ServiceName}Rs"]["ServiceBody"]);
        }

        private class EsbRequest {
            public EsbAmHeader amheader { get; set; }
            public IDictionary<string, EsbServiceRq> ambody { get; set; }
        }

        private class EsbAmHeader {
            public string ChannelID { get; set; }
            public string ServiceDomain { get; set; }
            public string OperationName { get; set; }
            public string ConsumerID { get; set; }
            public string TransactionID { get; set; }
            public DateTime RqTimestamp { get; set; }
        }

        private class EsbServiceRq {
            public EsbServiceHeader ServiceHeader { get; set; }
            public EsbSignon Signon { get; set; }
            public EsbRqServiceBody ServiceBody { get; set; }
        }

        private class EsbServiceHeader {
            public string TxnId { get; set; }
            public string TxnNo { get; set; }
            public string SvcVer { get; set; }
        }

        private class EsbSignon {
            public string CustId { get; set; }
            [SensitiveData]
            public string CustPswd { get; set; }
        }
    }
}