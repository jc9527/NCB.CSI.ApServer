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
    [Validator(typeof(LoanRenewInfoInqRqValidator))]
    public class LoanRenewInfoInqRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string AppNo { get; set; }
    }
    public class LoanRenewInfoInqRqValidator : AbstractValidator<LoanRenewInfoInqRq> {
        public LoanRenewInfoInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.AppNo).NotEmpty();
        }
    }
    public class LoanRenewInfoInqRs : EsbNonT24CommonRs {
        public LoanRenewInfoInqLoanRenewInqRec LoanRenewInqRec { get; set; }
    }
    public class LoanRenewInfoInqLoanRenewInqRec {
        public string LoanType { get; set; }
        public string ApprvAmt { get; set; }
        public string LoanTerm { get; set; }
        public string CtrctEffDate { get; set; }
        public string CtrctExpDate { get; set; }
        public string RenewEffDate { get; set; }
        public string RenewExpDate { get; set; }
    }
}
