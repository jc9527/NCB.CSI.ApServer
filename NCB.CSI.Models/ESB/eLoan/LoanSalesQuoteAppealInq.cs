using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(LoanSalesQuoteAppealInqRqValidator))]
    public class LoanSalesQuoteAppealInqRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string AppNo { get; set; }
    }
    public class LoanSalesQuoteAppealInqRqValidator : AbstractValidator<LoanSalesQuoteAppealInqRq> {
        public LoanSalesQuoteAppealInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.AppNo).NotEmpty();
        }
    }
    public class LoanSalesQuoteAppealInqRs : EsbNonT24CommonRs {
        public LoanSalesQuoteAppealInqLoanSalesQuoteInqRec LoanSalesQuoteInqRec { get; set; }
    }
    public class LoanSalesQuoteAppealInqLoanSalesQuoteInqRec {
        public string CustPermId { get; set; }
        public string AppNo { get; set; }
        public string LoanType { get; set; }
        public string LoanTerm { get; set; }
        public LoanSalesQuoteAppealInqRateInfo RateInfo { get; set; }
        public string ApprvStat { get; set; }
        public string ApprvDate { get; set; }
        public string RjctCode { get; set; }
    }
    public class LoanSalesQuoteAppealInqRateInfo {
        public string Term { get; set; }
        public string RateCode { get; set; }
        public string IntrstRate { get; set; }
    }
}
