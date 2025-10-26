using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(DbCardFeeAddRqValidator))]
    public class DbCardFeeAddRq : EsbDebitCardCommonRq {
        public string CardNo { get; set; }
        public string TxnCode { get; set; }
        public string DestAmt { get; set; }
        public string BillDesc { get; set; }
        public string UpdtUserId { get; set; }
        public string SprvsrlId { get; set; }
    }
    public class DbCardFeeAddRqValidator : AbstractValidator<DbCardFeeAddRq> {
        public DbCardFeeAddRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.TxnCode).NotEmpty();
            RuleFor(x => x.DestAmt).NotEmpty();
            RuleFor(x => x.UpdtUserId).NotEmpty();
            RuleFor(x => x.SprvsrlId).NotEmpty();
        }
    }
    public class DbCardFeeAddRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
