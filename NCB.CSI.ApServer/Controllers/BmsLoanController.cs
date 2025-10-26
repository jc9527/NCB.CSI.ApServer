using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Base;
using NCB.CSI.ApServer.Services.BMS.CreateAccount;
using NCB.CSI.Models.BMS.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using NCB.CSI.ApServer.Services.BMS.Loan;
using Devpro.Shared.Token;
using Devpro.Shared.ActionFilters;

namespace NCB.CSI.ApServer.Controllers {
    [RoutePrefix("BMS/Loan")]
    [JwtValidation(TokenLevel.None)]
    public class BmsLoanController : BaseController {
        /// <summary>
        /// 查詢貸款進件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetLoanInfo")]
        public Task<Response<GetLoanInfoRs>> GetLoanInfo(Request<GetLoanInfoRq> request) => SvcRepo.Resolve<GetLoanInfo>().RunAsync(request);

        /// <summary>
        /// 依身分證字號取得貸款案件
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("GetLoanInfoById")]
        public Task<Response<GetLoanInfoRs>> GetLoanInfoById(Request<GetLoanInfoByIdRq> request) => SvcRepo.Resolve<GetLoanInfoById>().RunAsync(request);

        /// <summary>
        /// 貸款補傳送email契據
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SendForEmail")]
        public Task<Response<SendForEmailRs>> SendForEmail(Request<SendForEmailRq> request) => SvcRepo.Resolve<SendForEmail>().RunAsync(request);

    }
}