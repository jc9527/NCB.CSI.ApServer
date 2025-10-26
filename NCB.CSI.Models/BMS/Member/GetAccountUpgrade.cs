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
    [Validator(typeof(GetAccountUpgradeRqValidator))]
    public class GetAccountUpgradeRq {
        public string memberId { get; set; }
        public string status { get; set; }
    }

    public class GetAccountUpgradeRqValidator : AbstractValidator<GetAccountUpgradeRq> {
        public GetAccountUpgradeRqValidator() {
            RuleFor(x => x.memberId).NotEmpty();
            RuleFor(x => x.status).NotEmpty();
        }
    }

    public class GetAccountUpgradeRs : BmsCommonRs<GetAccountUpgradeData> {
    }

    public class GetAccountUpgradeData {
        public bool? isPass { get; set; }
        public string reason { get; set; }
        public string createdAt { get; set; }
    }
}
