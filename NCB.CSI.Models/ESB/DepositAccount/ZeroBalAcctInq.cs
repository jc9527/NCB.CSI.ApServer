using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(ZeroBalAcctInqRqValidator))]
    public class ZeroBalAcctInqRq : EsbInqCommonRq {
        public string BrchId { get; set; }
    }

    public class ZeroBalAcctInqRqValidator : AbstractValidator<ZeroBalAcctInqRq> {
        public ZeroBalAcctInqRqValidator() {
        }
    }

    public class ZeroBalAcctInqRs : EsbT24InqCommonRs {
        public IEnumerable<ZeroBalAcctInqAcctRec> AcctRec { get; set; }
    }

    public class ZeroBalAcctInqAcctRec {
        public string AcctId { get; set; }
        public string Ccy { get; set; }
        public string BussType { get; set; }
        public string WorkBal { get; set; }
        public string ActlBal { get; set; }
        public string ClrBal { get; set; }
        public string BrchId { get; set; }
    }
}
