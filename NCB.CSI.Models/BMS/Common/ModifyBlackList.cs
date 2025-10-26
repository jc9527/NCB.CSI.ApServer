using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.Common {
    [Validator(typeof(ModifyBlackListRqValidator))]
    public class ModifyBlackListRq {
        public string actionType { get; set; }
        public string blackListSeqNo { get; set; }
        public string identity { get; set; }
        public string category { get; set; }
        public string delReason { get; set; }
        public string modifier { get; set; }
    }

    public class ModifyBlackListRqValidator : AbstractValidator<ModifyBlackListRq> {
        public ModifyBlackListRqValidator() {
            RuleFor(x => x.actionType).NotEmpty();
            RuleFor(x => x.blackListSeqNo).NotEmpty();
            //RuleFor(x => x.identity).NotEmpty();
            //RuleFor(x => x.category).NotEmpty();
            RuleFor(x => x.delReason).NotEmpty();
            RuleFor(x => x.modifier).NotEmpty();
        }
    }

    public class ModifyBlackListRs : BmsCommonRs<object> {
    }
}
