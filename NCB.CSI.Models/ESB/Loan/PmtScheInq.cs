using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Loan {
    [Validator(typeof(PmtScheInqRqValidator))]
    public class PmtScheInqRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
    }
    public class PmtScheInqRqValidator : AbstractValidator<PmtScheInqRq> {
        public PmtScheInqRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
        }
    }
    public class PmtScheInqRs : EsbT24InqCommonRs {
        public IEnumerable<PmtScheInqPmtRec> PmtRec { get; set; }
    }
    public class PmtScheInqPmtRec {
        public string ArrngId { get; set; }
        public IEnumerable<PmtScheInqPmtScheRec> PmtScheRec { get; set; }
    }
    public class PmtScheInqPmtScheRec {
        public string SchdDate { get; set; }
        public string TtlAmt { get; set; }
        public string PrncplAmt { get; set; }
        public string IntrstAmt { get; set; }
        public string HdlgChrg { get; set; }
        public string TtlTax { get; set; }
        public string PaidAmt { get; set; }
        public string TtlOutstndAmt { get; set; }
    }
}
