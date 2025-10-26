using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Devpro.Shared.Attributies;
using NCB.CSI.ApServer.AbstractServices;
using NCB.CSI.Models.BMS.Common;

namespace NCB.CSI.ApServer.Services.BMS.Common {
    /// <summary>
    /// 作服 - 取得EDD問卷資料
    /// </summary>
    [ServiceNamespace("common")]
    public class GetEDDSurvey : BmsService<GetEDDSurveyRq, GetEDDSurveyRs> {
        public override async Task<(GetEDDSurveyRs Result, string ResultCode, string ResultMessage)>
            RunAsync(GetEDDSurveyRq model) => BmsResult(await PostAsync(model));
    }
}