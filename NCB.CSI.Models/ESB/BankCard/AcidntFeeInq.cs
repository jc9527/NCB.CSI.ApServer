using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(AcidntFeeInqRqValidator))]
    public class AcidntFeeInqRq : EsbBankCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
    }
    public class AcidntFeeInqRqValidator : AbstractValidator<AcidntFeeInqRq> {
        public AcidntFeeInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
        }
    }
    public class AcidntFeeInqRs : EsbNonT24CommonRs {
       public AcidntFeeInqCardAcidntInfo CardAcidntInfo { get; set; }
    }
    public class AcidntFeeInqCardAcidntInfo {
        public string ChrgFeeFlg { get; set; }
    }
}
