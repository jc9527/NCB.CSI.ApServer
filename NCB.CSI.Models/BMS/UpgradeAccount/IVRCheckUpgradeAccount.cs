using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.UpgradeAccount {
    [Validator(typeof(IVRCheckUpgradeAccountRqValidator))]
    public class IVRCheckUpgradeAccountRq {
        public string memberId { get; set; }
        public bool isPass { get; set; }
    }

    public class IVRCheckUpgradeAccountRqValidator : AbstractValidator<IVRCheckUpgradeAccountRq> {
        public IVRCheckUpgradeAccountRqValidator() {
            RuleFor(x => x.memberId).NotEmpty();
            RuleFor(x => x.isPass).NotEmpty();
        }
    }

    public class IVRCheckUpgradeAccountRs : BmsCommonRs<object> {
    }
}
