using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDCalInqRqValidator))]
    public class TDCalInqRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
        public string CalId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    public class TDCalInqRqValidator : AbstractValidator<TDCalInqRq> {
        public TDCalInqRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
            RuleFor(x => x.CalId).NotEmpty();
            RuleFor(x => x.StartDate).Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndDate).Matches(RegExConst.YYYYMMDD);
        }
    }
    public class TDCalInqRs : EsbT24InqCommonRs {
        public IEnumerable< TDCalInqTDCalInqRec >TDCalInqRec { get; set; }
    }
    public class TDCalInqPageInfo {
        public string PageSize { get; set; }
        public string PageStart { get; set; }
        public string NoOfRec { get; set; }
        public string PageToken { get; set; }
    }
    public class TDCalInqAudit {
        public string T24Time { get; set; }
        public string VerNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class TDCalInqTDCalInqRec {
        public string ArrngId { get; set; }
        public IEnumerable< TDCalInqTDCalInqInfo >TDCalInqInfo { get; set; }
    }
    public class TDCalInqTDCalInqInfo {
        public string SimDate { get; set; }
        public string TtlDueAmt { get; set; }
        public string IntrstAmt { get; set; }
        public string PrncplAmt { get; set; }
        public string CurPrdIntrstAmt { get; set; }
        public string IntrstRate { get; set; }
        public string HdlgChrg { get; set; }
        public string WHTAmt { get; set; }
        public string TtlIntrstAmt { get; set; }
        public string OutstndAmt { get; set; }
    }
}
