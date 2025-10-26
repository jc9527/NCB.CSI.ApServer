using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.OTP {
    [Validator(typeof(svVerify_SMSRqValidator))]
    public class svVerify_SMSRq : OtpCommonRq {
        public string phoneNo { get; set; }
        public string otp { get; set; }
        public string oNO { get; set; }
    }

    public class svVerify_SMSRqValidator : AbstractValidator<svVerify_SMSRq> {
        public svVerify_SMSRqValidator() {
            RuleFor(x => x.phoneNo).NotEmpty();
            RuleFor(x => x.otp).NotEmpty();
            RuleFor(x => x.oNO).NotEmpty();
        }
    }

    public class svVerify_SMSRs : OtpCommonRs {
    }
}
