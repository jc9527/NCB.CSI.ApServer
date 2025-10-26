using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.Common {
    [Validator(typeof(BankRqValidator))]
    public class BankRq {
        public string locale { get; set; }
        public string queryType { get; set; }
        public string bankType { get; set; }
        public string branchBank { get; set; }
    }

    public class BankRqValidator : AbstractValidator<BankRq> {
        public BankRqValidator() {
            RuleFor(x => x.locale).NotEmpty();
            RuleFor(x => x.queryType).NotEmpty();
        }
    }

    public class BankRs : BmsCommonRs<IEnumerable<BankItem>> {
    }

    public class BankItem {
        public string code { get; set; }
        public string name { get; set; }
    }
}
