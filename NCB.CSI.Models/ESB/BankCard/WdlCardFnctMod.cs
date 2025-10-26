using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(WdlCardFnctModRqValidator))]
    public class WdlCardFnctModRq : EsbRqServiceBody {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        public string CardStatFlg { get; set; }
        public string NonRsrvdFundXfer { get; set; }
        public string XbrdrWdlFnct { get; set; }
    }
    public class WdlCardFnctModRqValidator : AbstractValidator<WdlCardFnctModRq> {
        public WdlCardFnctModRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
        }
    }
    public class WdlCardFnctModRs : EsbNonT24CommonRs {
    }
}
