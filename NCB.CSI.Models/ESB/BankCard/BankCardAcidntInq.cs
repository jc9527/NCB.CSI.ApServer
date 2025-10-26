using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardAcidntInqRqValidator))]
    public class BankCardAcidntInqRq : EsbBankCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
    }
    public class BankCardAcidntInqRqValidator : AbstractValidator<BankCardAcidntInqRq> {
        public BankCardAcidntInqRqValidator() {
            RuleFor(X => X.CardNo).NotEmpty();
        }
    }
    public class BankCardAcidntInqRs : EsbNonT24CommonRs {
        public IEnumerable<BankCardAcidntInqCardAcidntRec> CardAcidntRec { get; set; }
        public BankCardAcidntInqControlRec ControlRec { get; set; }
    }
    public class BankCardAcidntInqCardAcidntRec {
        public string CustPermId { get; set; }
        public string CustChnName { get; set; }
        public string CardType { get; set; }
        public string CardTypeName { get; set; }
        public string CardFace { get; set; }
        public string CardFaceName { get; set; }
        public string CardAtt { get; set; }
        public string CardAttName { get; set; }
        public string DbAcctNo { get; set; }
        public string CardNo { get; set; }
        public string AcidntType { get; set; }
        public string AcidntTypeName { get; set; }
        public string AcidntDate { get; set; }
        public string AcidntSrcId { get; set; }
        public string AcidntAppId { get; set; }

    }
    public class BankCardAcidntInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }

    }
}
