using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(PreDsgntdLmtModRqValidator))]
    public class PreDsgntdLmtModRq : EsbRqServiceBody {
        public string CustPermId { get; set; }
        public string AcctNo { get; set; }
        public string ChanId { get; set; }
        public string PDLmtAmt { get; set; }
        public string UpdtUserId { get; set; }
        public string UpdtBrchId { get; set; }
    }
    public class PreDsgntdLmtModRqValidator : AbstractValidator<PreDsgntdLmtModRq> {
        public PreDsgntdLmtModRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$");
            RuleFor(x => x.AcctNo).NotEmpty();
            RuleFor(x => x.ChanId).NotEmpty();
            RuleFor(x => x.PDLmtAmt).NotEmpty();
            RuleFor(x => x.UpdtUserId).NotEmpty();
            RuleFor(x => x.UpdtBrchId).NotEmpty();
        }
    }
    public class PreDsgntdLmtModRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
