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
    [Validator(typeof(LoanRenewStatModRqValidator))]
    public class LoanRenewStatModRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string AppNo { get; set; }
        public string RenewFlg { get; set; }
        public string NonRenewRsn { get; set; }
        public string IPAddr { get; set; }
        public string RplyDate { get; set; }
    }
    public class LoanRenewStatModRqValidator : AbstractValidator<LoanRenewStatModRq> {
        public LoanRenewStatModRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.AppNo).NotEmpty();
            RuleFor(x => x.RenewFlg).NotEmpty();
            RuleFor(x => x.IPAddr).NotEmpty();
            RuleFor(x => x.RplyDate).NotEmpty().Matches(RegExConst.iso8601);
        }
    }
    public class LoanRenewStatModRs : EsbNonT24CommonRs {
        public LoanRenewStatModLoanRenewStatModRec LoanRenewStatModRec { get; set; }
    }
    public class LoanRenewStatModLoanRenewStatModRec {
        public string CustPermId { get; set; }
        public string AppNo { get; set; }
    }
}
