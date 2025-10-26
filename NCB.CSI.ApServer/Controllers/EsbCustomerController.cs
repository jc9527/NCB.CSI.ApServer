using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.ActionFilters;
using Devpro.Shared.Base;
using Devpro.Shared.Token;
using NCB.CSI.ApServer.Services.ESB.Customer;
using NCB.CSI.Models.ESB.Customer;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("ESB/Customer")]
    [JwtValidation(TokenLevel.None)]
    public class EsbCustomerController : BaseController {
        /// <summary>
        /// CIF(個人戶)維護
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CustProfMod")]
        public Task<Response<CustProfModRs>> CustProfMod(Request<CustProfModRq> request) => SvcRepo.Resolve<CustProfMod>().RunAsync(request);
        /// <summary>
        /// AllInOne客戶及帳戶資料查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CustSummInq")]
        public Task<Response<CustSummInqRs>> CustSummInq(Request<CustSummInqRq> request) => SvcRepo.Resolve<CustSummInq>().RunAsync(request);
        /// <summary>
        /// Email(手機)查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CustIdntInq")]
        public Task<Response<CustIdntInqRs>> CustIdntInq(Request<CustIdntInqRq> request) => SvcRepo.Resolve<CustIdntInq>().RunAsync(request);
        /// <summary>
        ///  CIF層事故歷史查詢
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CIFRstrctHistInq")]
        public Task<Response<CIFRstrctHistInqRs>> CIFRstrctHistInq(Request<CIFRstrctHistInqRq> request) => SvcRepo.Resolve<CIFRstrctHistInq>().RunAsync(request);
        /// <summary>
        ///  CIF(個人戶)完整建檔
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CustProfAdd")]
        public Task<Response<CustProfAddRs>> CustProfAdd(Request<CustProfAddRq> request) => SvcRepo.Resolve<CustProfAdd>().RunAsync(request);
        /// <summary>
        /// 同步異動CIF資料
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("CustProfSync")]
        public Task<Response<CustProfSyncRs>> CustProfSync(Request<CustProfSyncRq> request) => SvcRepo.Resolve<CustProfSync>().RunAsync(request);
    }
}
