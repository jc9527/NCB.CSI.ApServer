using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.UpgradeAccount {
    [Validator(typeof(GetEddaCheckResultRqValidator))]
    public class GetEddaCheckResultRq {
        public string pid { get; set; }
        public string action { get; set; }
    }

    public class GetEddaCheckResultRqValidator : AbstractValidator<GetEddaCheckResultRq> {
        public GetEddaCheckResultRqValidator() {
            RuleFor(x => x.pid).NotEmpty();
            RuleFor(x => x.action).NotEmpty();
        }
    }

    public class GetEddaCheckResultRs : BmsCommonRs<GetEddaCheckResultData> {
    }

    public class GetEddaCheckResultData {
        public string status { get; set; }
        public string transDateTime { get; set; }
    }
}
