using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardResndHistInqRqValidator))]
    public class BankCardResndHistInqRq : EsbBankCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
    }
    public class BankCardResndHistInqRqValidator : AbstractValidator<BankCardResndHistInqRq> {
        public BankCardResndHistInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.PageNo).NotEmpty();
        }
    }
    public class BankCardResndHistInqRs : EsbNonT24CommonRs {
        public BankCardResndHistInqCardResndHistRec CardResndHistRec { get; set; }
        public BankCardResndHistInqControlRec ControlRec { get; set; }
    }
    public class BankCardResndHistInqCardResndHistRec {
        public string CustPermId { get; set; }
        public string CardChnName { get; set; }
        public string CardType { get; set; }
        public string CardTypeName { get; set; }
        public string CardFace { get; set; }
        public string CardFaceName { get; set; }
        public string CardAtt { get; set; }
        public string CardAttName { get; set; }
        public string DbAcctNo { get; set; }
        public string CardNo { get; set; }
        public string OldCardNo { get; set; }
        public string ResndDate { get; set; }
        public string ResndSrcId { get; set; }
        public string ResndAppId { get; set; }
        public string AcidntType { get; set; }
        public string AcidntTypeName { get; set; }
        public string AcidntDate { get; set; }
        public string AcidntSrcId { get; set; }
        public string AcidntAppId { get; set; }

    }
    public class BankCardResndHistInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
