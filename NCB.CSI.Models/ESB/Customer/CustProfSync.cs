using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Customer {
    [Validator(typeof(CustProfSyncRqValidator))]
    public class CustProfSyncRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public CustProfModCustProfInfo CustProfInfo { get; set; }
    }

    public class CustProfSyncRqValidator : AbstractValidator<CustProfSyncRq> {
        public CustProfSyncRqValidator() {
            RuleFor(x => x.CustProfInfo).NotEmpty();
        }
    }

    public class CustProfSyncRs : EsbT24CommonRs {
        public EsbRtrnStatCode CMSRsRec { get; set; }
        public EsbRtrnStatCode DCSRsRec { get; set; }
        public EsbHeaderInfo HeaderInfo { get; set; }
        public CustProfModCustProfInfo CustInfo { get; set; }
    }
}
