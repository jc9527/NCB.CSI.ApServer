using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(DbCardResndAppntAddRqValidator))]
    public class DbCardResndAppntAddRq : EsbDebitCardCommonRq {
        public string CardNo { get; set; }
        public string ResndAppntType { get; set; }
        public string ResndAppntCode { get; set; }
        public string ExpAppntRsnCode { get; set; }
        public string ExpUpdtDate { get; set; }
        public string ResndRsn { get; set; }
        public string ResndDate { get; set; }
    }
    public class DbCardResndAppntAddRqValidator : AbstractValidator<DbCardResndAppntAddRq> {
        public DbCardResndAppntAddRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.ResndAppntType).NotEmpty();
            RuleFor(x => x.ResndAppntCode).NotEmpty();
        }
    }
    public class DbCardResndAppntAddRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
