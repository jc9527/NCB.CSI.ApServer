using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.Common {
    [Validator(typeof(CreateBlackListRqValidator))]
    public class CreateBlackListRq {
        public string identity { get; set; }
        public string category { get; set; }
        public string createReason { get; set; }
        public string creator { get; set; }
    }

    public class CreateBlackListRqValidator : AbstractValidator<CreateBlackListRq> {
        public CreateBlackListRqValidator() {
            RuleFor(x => x.identity).NotEmpty();
            RuleFor(x => x.category).NotEmpty();
            RuleFor(x => x.createReason).NotEmpty();
            RuleFor(x => x.creator).NotEmpty();
        }
    }

    public class CreateBlackListRs : BmsCommonRs<object> {
    }
}
