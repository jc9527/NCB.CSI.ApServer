using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(LoanSalesQuoteInqRqValidator))]
    public class LoanSalesQuoteInqRq : EsbRqServiceBody {
        public string IBMBAppNo { get; set; }
        public string AppNo { get; set; }
    }
    public class LoanSalesQuoteInqRqValidator : AbstractValidator<LoanSalesQuoteInqRq> {
        public LoanSalesQuoteInqRqValidator() {
            RuleFor(x => x.IBMBAppNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.AppNo));
            RuleFor(x => x.AppNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.IBMBAppNo));
        }
    }
    public class LoanSalesQuoteInqRs : EsbNonT24CommonRs {
        public LoanSalesQuoteInqLoanSalesQuoteInqRec LoanSalesQuoteInqRec { get; set; }
    }
    public class LoanSalesQuoteInqLoanSalesQuoteInqRec {
        public string CustPermId { get; set; }
        public string AppNo { get; set; }
        public string LoanType { get; set; }
        public string ApprvAmt { get; set; }
        public string LoanTerm { get; set; }
        public string GracePrd { get; set; }
        public IEnumerable<LoanSalesQuoteInqRatesInfo> RatesInfo { get; set; }
        public IEnumerable<LoanSalesQuoteInqFeeInfo> FeeInfo { get; set; }
        public string RepmtMthd { get; set; }
        public string RevolvFlg { get; set; }
        public string ApprvStat { get; set; }
        public string ApprvDate { get; set; }
        public string RjctCode { get; set; }
    }
    public class LoanSalesQuoteInqRatesInfo {
        public string Term { get; set; }
        public string RateCode { get; set; }
        public string IntrstRate { get; set; }
    }
    public class LoanSalesQuoteInqFeeInfo {
        public string FeeType { get; set; }
        public string CntType { get; set; }
        public decimal RsltAmt { get; set; }
    }
}
