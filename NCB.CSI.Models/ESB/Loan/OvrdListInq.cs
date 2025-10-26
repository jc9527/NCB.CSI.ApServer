using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Loan {
    [Validator(typeof(OvrdListInqRqValidator))]
    public class OvrdListInqRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
        public string AcctNo { get; set; }
        public string CustPermId { get; set; }
        public string CIFNo { get; set; }
    }
    public class OvrdListInqRqValidator : AbstractValidator<OvrdListInqRq> {
        public OvrdListInqRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty().When(x => string.IsNullOrEmpty(x.AcctNo) && string.IsNullOrEmpty(x.CustPermId) && string.IsNullOrEmpty(x.CIFNo));
            RuleFor(x => x.AcctNo).NotEmpty().When(x => string.IsNullOrEmpty(x.ArrngId) && string.IsNullOrEmpty(x.CustPermId) && string.IsNullOrEmpty(x.CIFNo));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrEmpty(x.AcctNo) && string.IsNullOrEmpty(x.ArrngId) && string.IsNullOrEmpty(x.CIFNo));
            RuleFor(x => x.CIFNo).NotEmpty().When(x => string.IsNullOrEmpty(x.ArrngId) && string.IsNullOrEmpty(x.AcctNo) && string.IsNullOrEmpty(x.CustPermId));
        }
    }
    public class OvrdListInqRs : EsbT24InqCommonRs {
        public IEnumerable<OvrdListInqOvrdListInqRec> OvrdListInqRec { get; set; }
    }
    public class OvrdListInqPageInfo {
        public string PageSize { get; set; }
        public string PageStart { get; set; }
        public string NoOfRec { get; set; }
        public string PageToken { get; set; }
    }
    public class OvrdListInqAudit {
        public string T24Time { get; set; }
        public string VerNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class OvrdListInqOvrdListInqRec {
        public string CIFNo { get; set; }
        public string CustShrtName { get; set; }
        public IEnumerable<OvrdListInqOvrdListInqInfo> OvrdListInqInfo { get; set; }
    }
    public class OvrdListInqOvrdListInqInfo {
        public string TtlOvrdAmt { get; set; }
        public string TtlLoanBal { get; set; }
        public IEnumerable<OvrdListInqOvrdListInfo> OvrdListInfo { get; set; }
    }
    public class OvrdListInqOvrdListInfo {
        public string ArrngId { get; set; }
        public string Ccy { get; set; }
        public string OvrdDate { get; set; }
        public string AcctStat { get; set; }
        public string OvrdAmt { get; set; }
        public string LoanBal { get; set; }
    }
}
