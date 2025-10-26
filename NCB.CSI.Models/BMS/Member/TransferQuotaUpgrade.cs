using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Member {
    [Validator(typeof(TransferQuotaUpgradeRqValidator))]
    public class TransferQuotaUpgradeRq {
        public string memberId { get; set; }
        public bool? isPass { get; set; }
        public string reason { get; set; }
    }

    public class TransferQuotaUpgradeRqValidator : AbstractValidator<TransferQuotaUpgradeRq> {
        public TransferQuotaUpgradeRqValidator() {
            RuleFor(x => x.memberId).NotEmpty();
            RuleFor(x => x.isPass).NotEmpty();
        }
    }

    public class TransferQuotaUpgradeRs : BmsCommonRs<object> {
    }
}
