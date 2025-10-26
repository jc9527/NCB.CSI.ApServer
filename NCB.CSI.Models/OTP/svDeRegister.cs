using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.OTP {
    [Validator(typeof(svDeRegisterRqValidator))]
    public class svDeRegisterRq : OtpCommonRq {
    }

    public class svDeRegisterRqValidator : AbstractValidator<svDeRegisterRq> {
    }

    public class svDeRegisterRs : OtpCommonRs {
        public string memberStatus { get; set; }
    }
}
