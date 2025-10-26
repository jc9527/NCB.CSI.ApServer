using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Loan {
    [Validator(typeof(LoanStatInqRqValidator))]
    public class LoanStatInqRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
        public string StartDate { get; set; }
    }
    public class LoanStatInqRqValidator : AbstractValidator<LoanStatInqRq> {
        public LoanStatInqRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
            RuleFor(x => x.StartDate).Matches(RegExConst.YYYYMMDD);
        }
    }
    public class LoanStatInqRs : EsbT24InqCommonRs {
        public IEnumerable<LoanStatInqLoanStatRec> LoanStatRec { get; set; }
    }

    public class LoanStatInqLoanStatRec {
        public string CustId { get; set; }
        public string CustName { get; set; }
        public string ArrngId { get; set; }
        public IEnumerable<LoanStatInqLoanStatInfo> LoanStatInfo { get; set; }
    }

    public class LoanStatInqLoanStatInfo {
        public string ProdType { get; set; }
        public string Ccy { get; set; }
        public decimal? IntrstRate { get; set; }
        public decimal? CmmtmntAmt { get; set; }
        public decimal? AvailLmtAmt { get; set; }
        public decimal? LoanBal { get; set; }
        public decimal? PrncplBal { get; set; }
        public string LoanEffDate { get; set; }
        public string LoanExpDate { get; set; }
        public string LoanStat { get; set; }
        public string RepmtType { get; set; }
        public string RepmtFreq { get; set; }
        public decimal? OvrdPrncpl { get; set; }
        public decimal? OvrdIntrst { get; set; }
        public decimal? DueFeeAmt { get; set; }
        public decimal? PnltyIntrst { get; set; }
        public decimal? OvrdTtlAmt { get; set; }
    }
}
