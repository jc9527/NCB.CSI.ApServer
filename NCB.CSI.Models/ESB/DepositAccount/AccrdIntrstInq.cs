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
    [Validator(typeof(AccrdIntrstInqRqValidator))]
    public class AccrdIntrstInqRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
    }

    public class AccrdIntrstInqRqValidator : AbstractValidator<AccrdIntrstInqRq> {
        public AccrdIntrstInqRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
        }
    }

    public class AccrdIntrstInqRs : EsbT24InqCommonRs {
        public IEnumerable<AccrdIntrstInqAcctInfo> AcctInfo { get; set; }
    }

    public class AccrdIntrstInqAcctInfo {
        public string ArrngId { get; set; }
        public IEnumerable<AccrdIntrstInqAcctRec> AcctRec { get; set; }
    }

    public class AccrdIntrstInqAcctRec {
        public string AcctId { get; set; }
        public string DfrrdDate { get; set; }
        public string IntrstRateType { get; set; }
        public string TtlIntrstAmt { get; set; }
        public string TtlSuspAmt { get; set; }
        public string TtlDelqAmt { get; set; }
        public string TtlRpyAmt { get; set; }
        public string PnltyIntrst { get; set; }
        public string PnltyIntrstSP { get; set; }
        public IEnumerable<AccrdIntrstInqAccruAmtRec> AccruAmtRec { get; set; }
    }

    public class AccrdIntrstInqAccruAmtRec {
        public string StrtDate { get; set; }
        public string EndDate { get; set; }
        public string Days { get; set; }
        public string Bal { get; set; }
        public string IntrstRate { get; set; }
        public string AccruAmt { get; set; }
        public string ActlAccruAmt { get; set; }
    }
}
