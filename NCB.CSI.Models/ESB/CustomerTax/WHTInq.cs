using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.CustomerTax {
    [Validator(typeof(WHTInqRqValidator))]
    public class WHTInqRq : EsbInqCommonRq {
        public string CustPermId { get; set; }
        public string AcctNo { get; set; }
        public string StartDateEndDate { get; set; }
    }
    public class WHTInqRqValidator : AbstractValidator<WHTInqRq> {
        public WHTInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$").When(x => string.IsNullOrWhiteSpace(x.AcctNo));
            RuleFor(x => x.AcctNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
        }
    }
    public class WHTInqRs : EsbT24InqCommonRs {
        public IEnumerable<WHTInqWHTTaxInqRec> WHTTaxInqRec { get; set; }
    }
    public class WHTInqWHTTaxInqRec {
        public string RecSeqNo { get; set; }
        public IEnumerable<WHTInqWHTInqInfo> WHTInqInfo { get; set; }

    }
    public class WHTInqWHTInqInfo {
        public string CoCode { get; set; }
        public string Res183Flg { get; set; }
        public string CustId { get; set; }
        public string CustPermId { get; set; }
        public string AcctNo { get; set; }
        public string Natl { get; set; }
        public string Sctr { get; set; }
        public string ProdName { get; set; }
        public string WHTRate { get; set; }
        public string ArrngId { get; set; }
        public string IntrstYrMnth { get; set; }
        public string IntrstDate { get; set; }
        public string AcctCcy { get; set; }
        public string FCYIntrstAmt { get; set; }
        public string FCYWHTAmt { get; set; }
        public string ForExRate { get; set; }
        public string LCYIntrstAmt { get; set; }
        public string LCYWHTAmt { get; set; }
        public string TtlFCYWHTAmt { get; set; }
        public string TtlLCYTtlWHTAmt { get; set; }
        public string CampInstrstType { get; set; }
        public string WHTVchrDate { get; set; }
        public string NHIRate { get; set; }
        public string FCYNHIAmt { get; set; }
        public string LCYNHIAmt { get; set; }
        public string TxnRefNo { get; set; }
        public string NHISrlNo { get; set; }
        public IEnumerable<WHTInqIntrstActTypeInfo> IntrstActTypeInfo { get; set; }
        public IEnumerable<WHTInqRefundTaxInfo> RefundTaxInfo { get; set; }
    }
    public class WHTInqIntrstActTypeInfo {
        public string IntrstActType { get; set; }
    }
    public class WHTInqRefundTaxInfo {
        public string FCYRefundTaxAmt { get; set; }
        public string LCYRefundTaxAmt { get; set; }
        public string RefundTaxDate { get; set; }
        public string RefundTaxActType { get; set; }
        public string RefundTaxRefNo { get; set; }
    }
}
