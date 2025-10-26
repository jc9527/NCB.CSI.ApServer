using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardHistInqRqValidator))]
    public class BankCardHistInqRq : EsbBankCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }
    public class BankCardHistInqRqValidator : AbstractValidator<BankCardHistInqRq> {
        public BankCardHistInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$").When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }
    public class BankCardHistInqRs : EsbNonT24CommonRs {
        public IEnumerable<BankCardHistInqCardHistRec>  CardHistRec { get; set; }
        public BankCardHistInqControlRec ControlRec { get; set; }
    }
    public class BankCardHistInqCardHistRec {
        public string CusPermtId { get; set; }
        public string ChnName { get; set; }
        public string CardType { get; set; }
        public string CardTypeName { get; set; }
        public string CardFace { get; set; }
        public string CardFaceName { get; set; }
        public string CardKind { get; set; }
        public string CardKindName { get; set; }
        public string DbAcctNo { get; set; }
        public string CardNo { get; set; }
        public string OldCardNo { get; set; }
        public string CardStatCode { get; set; }
        public string CardStatName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string SrcCode { get; set; }
        public string TlrId { get; set; }
        public string CardGrade { get; set; }
        public string GrpCode { get; set; }
        public string ElekCardType { get; set; }

    }
    public class BankCardHistInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
