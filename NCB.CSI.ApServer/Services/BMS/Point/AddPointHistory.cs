using Devpro.Models;
using Devpro.Shared;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace NCB.CSI.ApServer.Services.BMS.Point {
    /// <summary>
    /// 客服 - 新增客服加/扣點紀錄
    /// </summary>
    [ServiceNamespace("point")]
    public class AddPointHistory : BmsService<AddPointHistoryRq, AddPointHistoryRs> {
        public override async Task<(AddPointHistoryRs Result, string ResultCode, string ResultMessage)>
            RunAsync(AddPointHistoryRq model) => BmsResult(await PostAsync(model));
    }
}