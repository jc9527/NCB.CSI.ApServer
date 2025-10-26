using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.OTP {
    [Validator(typeof(OtpCommonRqValidator))]
    public class OtpCommonRq {
        public string idgateID { get; set; }
        public string channel { get; set; }
    }

    public class OtpCommonRqValidator : AbstractValidator<OtpCommonRq> {
        public OtpCommonRqValidator() {
            RuleFor(x => x.idgateID).NotEmpty();
            RuleFor(x => x.channel).NotEmpty();
        }
    }

    public class OtpCommonRs {
        public string returnCode { get; set; }
        public string returnMsg { get; set; }
        public bool success => returnCode == "0000";
    }
}
