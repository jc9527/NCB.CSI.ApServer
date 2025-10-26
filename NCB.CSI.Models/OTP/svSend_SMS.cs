using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.OTP {
    [Validator(typeof(svSend_SMSRqValidator))]
    public class svSend_SMSRq : OtpCommonRq {
        public string phoneNo { get; set; }
    }

    public class svSend_SMSRqValidator : AbstractValidator<svSend_SMSRq> {
        public svSend_SMSRqValidator() {
            RuleFor(x => x.phoneNo).NotEmpty();
        }
    }

    public class svSend_SMSRs : OtpCommonRs {
        public string otp { get; set; }
        public string oNO { get; set; }
    }
}
