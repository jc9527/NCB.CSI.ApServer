using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(XbrdWdlCardPswdCntModRqValidator))]
    public class XbrdWdlCardPswdCntModRq : EsbDebitCardCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        public string UpdtUserId { get; set; }
    }

    public class XbrdWdlCardPswdCntModRqValidator : AbstractValidator<XbrdWdlCardPswdCntModRq> {
        public XbrdWdlCardPswdCntModRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.UpdtUserId).NotEmpty();
        }
    }

    public class XbrdWdlCardPswdCntModRs : EsbNonT24CommonRs {
    }
}
