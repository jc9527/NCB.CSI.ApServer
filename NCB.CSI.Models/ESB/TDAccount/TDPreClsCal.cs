using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDPreClsCalRqValidator))]
    public class TDPreClsCalRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
        public string CalId { get; set; }
    }
    public class TDPreClsCalRqValidator : AbstractValidator<TDPreClsCalRq> {
        public TDPreClsCalRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
            RuleFor(x => x.CalId).NotEmpty();
        }
    }
    public class TDPreClsCalRs : EsbT24InqCommonRs {
        public IEnumerable<TDPreClsCalTDPreClsCalRec> MyProperty { get; set; }
    }
    public class TDPreClsCalPageInfo {
        public string PageSize { get; set; }
        public string PageStart { get; set; }
        public string NoOfRec { get; set; }
        public string PageToken { get; set; }
    }
    public class TDPreClsCalAudit {
        public string T24Time { get; set; }
        public string VerNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class TDPreClsCalTDPreClsCalRec {
        public string ArrngId { get; set; }
        public IEnumerable<TDPreClsCalTDPreClsCalInfo> TDPreClsCalInfo { get; set; }
    }
    public class TDPreClsCalTDPreClsCalInfo {
        public IEnumerable<TDPreClsCalAmtInfo> AmtInfo { get; set; }
    }
    public class TDPreClsCalAmtInfo {
        public string ParamKey { get; set; }
        public string ParamAmt { get; set; }
    }
}
