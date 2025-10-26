using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.CustomerTax;
using NCB.CSI.Models.ESB.CustomerTax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/CustomerTax")]
    [JwtValidation(TokenLevel.None)]
    public class EsbCustomerTaxController : BaseController {
        /// <summary>
        ///  年度代扣利息所得稅查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("WHTInq")]
        public Task<Response<WHTInqRs>> WHTInq(Request<WHTInqRq> request) => SvcRepo.Resolve<WHTInq>().RunAsync(request);
        /// <summary>
        ///  退稅交易
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("RefndWHTAdd")]
        public Task<Response<RefndWHTAddRs>> RefndWHTAdd(Request<RefndWHTAddRq> request) => SvcRepo.Resolve<RefndWHTAdd>().RunAsync(request);
        /// <summary>
        ///  補入差息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CrAdjIntrstAdd")]
        public Task<Response<CrAdjIntrstAddRs>> CrAdjIntrstAdd(Request<CrAdjIntrstAddRq> request) => SvcRepo.Resolve<CrAdjIntrstAdd>().RunAsync(request);
        /// <summary>
        ///  補扣差息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("DbAdjIntrstAdd")]
        public Task<Response<DbAdjIntrstAddRs>> DbAdjIntrstAdd(Request<DbAdjIntrstAddRq> request) => SvcRepo.Resolve<DbAdjIntrstAdd>().RunAsync(request);
    }
}