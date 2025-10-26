using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Services.BMS.Member {
    /// <summary>
    /// 修改會員資料
    /// </summary>
    [ServiceNamespace("member")]
    public class UpdateMemberInfo : BmsService<UpdateMemberInfoRq, UpdateMemberInfoRs> {
        public UpdateMemberInfo() : base("v2.0") { }
        public override async Task<(UpdateMemberInfoRs Result, string ResultCode, string ResultMessage)>
            RunAsync(UpdateMemberInfoRq model) => BmsResult(await PostAsync(model));
    }
}