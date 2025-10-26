using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(PreDsgntdAcctStatAddRqValidator))]
    public class PreDsgntdAcctStatAddRq : EsbRqServiceBody {
        public string CustPermId { get; set; }
        public string ChanId { get; set; }
        public string IBMBNpdXferFlg { get; set; }
        public string ATMNpdXferFlg { get; set; }
        public string PDXferFlg { get; set; }
        public string ATMWdlFlg { get; set; }
        public string UpdtUserId { get; set; }
        public string UpdtBrchId { get; set; }
    }
    public class PreDsgntdAcctStatAddRqValidator : AbstractValidator<PreDsgntdAcctStatAddRq> {
        public PreDsgntdAcctStatAddRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$");
            RuleFor(x => x.ChanId).NotEmpty();
            RuleFor(x => x.UpdtUserId).NotEmpty();
            RuleFor(x => x.UpdtBrchId).NotEmpty();
        }
    }
    public class PreDsgntdAcctStatAddRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
