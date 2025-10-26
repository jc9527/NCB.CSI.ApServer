using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardOpenRqValidator))]
    public class BankCardOpenRq : EsbRqServiceBody {
        public string CardSeqNo { get; set; }
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        public string KeyType { get; set; }
        public string KeyVal { get; set; }
    }
    public class BankCardOpenRqValidator : AbstractValidator<BankCardOpenRq> {
        public BankCardOpenRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.KeyType).NotEmpty();
            RuleFor(x => x.KeyVal).NotEmpty();
        }
    }
    public class BankCardOpenRs : EsbNonT24CommonRs {
    }
}
