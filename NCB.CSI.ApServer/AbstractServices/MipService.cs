using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.AbstractServices;
using Devpro.Shared.Base;

namespace NCB.CSI.ApServer.AbstractServices {
    public abstract class MipService<TReqModel, TRespModel> : HttpService<TReqModel, TRespModel> {
        public MipService() : base(ConfigurationManager.AppSettings["MIP.BaseAddress"]) { }
        protected Task<TRespModel> PostAsync(TReqModel model) => Connector.PostAsJsonAsync<TRespModel>(ServiceName, model);
    }
}