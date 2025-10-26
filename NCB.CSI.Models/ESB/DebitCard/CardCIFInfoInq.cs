using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(CardCIFInfoInqRqValidator))]
    public class CardCIFInfoInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class CardCIFInfoInqRqValidator : AbstractValidator<CardCIFInfoInqRq> {
        public CardCIFInfoInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class CardCIFInfoInqRs : EsbNonT24CommonRs {
        public IEnumerable<CardCIFInfoInqCustProfInfo> CustProfInfo { get; set; }
        public CardCIFInfoInqControlRec ControlRec { get; set; }
    }

    public class CardCIFInfoInqCustProfInfo {
        public string CardNo { get; set; }
        public string CardAtt { get; set; }
        public string CIFNo { get; set; }
        public string AmtCcy { get; set; }
        public string SMSFlg { get; set; }
        public string eMailFlg { get; set; }
        public string PushAppFlg { get; set; }
        public string SMSAmt { get; set; }
        public string CashFlg { get; set; }
        public string SmartPayFlg { get; set; }
        public string HCEFlg { get; set; }
        public string SMSMinAmt { get; set; }
        public string RelnCode { get; set; }
    }

    public class CardCIFInfoInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
