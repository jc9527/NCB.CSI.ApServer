using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardRgstrRqValidator))]
    public class BankCardRgstrRq : EsbRqServiceBody {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        public string CardStatCode { get; set; }
        public string ChrgFlg { get; set; }
    }
    public class BankCardRgstrRqValidator : AbstractValidator<BankCardRgstrRq> {
        public BankCardRgstrRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.CardStatCode).NotEmpty();
            RuleFor(x => x.ChrgFlg).NotEmpty();
        }
    }
    public class BankCardRgstrRs : EsbNonT24CommonRs {
    }
}
