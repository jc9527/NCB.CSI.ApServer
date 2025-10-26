using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.OTP {
    [Validator(typeof(svGet_Device_StatusRqValidator))]
    public class svGet_Device_StatusRq : OtpCommonRq {
    }

    public class svGet_Device_StatusRqValidator : AbstractValidator<svGet_Device_StatusRq> {
        public svGet_Device_StatusRqValidator() {
        }
    }

    public class svGet_Device_StatusRs : OtpCommonRs {
        public svGet_Device_StatusRs_FailCount failCount { get; set; }
        public string memberStatus { get; set; }
        public svGet_Device_StatusRs_Type type { get; set; }
        public string label { get; set; }
        public string model { get; set; }
        public string os { get; set; }
    }

    public class svGet_Device_StatusRs_FailCount {
        public string digital { get; set; }
        public string pattern { get; set; }
    }

    public class svGet_Device_StatusRs_Type {
        public string diagram { get; set; }
        public string bio { get; set; }
        [JsonConverter(typeof(SecureStringConverter))]
        public SecureString pwd { get; set; }
    }
}
