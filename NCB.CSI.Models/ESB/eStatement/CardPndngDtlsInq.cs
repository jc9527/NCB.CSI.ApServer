using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eStatement {
    [Validator(typeof(CardPndngDtlsInqRqValidator))]
    public class CardPndngDtlsInqRq : EsbDebitCardInqCommonRq {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string InqMnth { get; set; }
    }
    public class CardPndngDtlsInqRqValidator : AbstractValidator<CardPndngDtlsInqRq> {
        public CardPndngDtlsInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.InqMnth).NotEmpty().Matches(RegExConst.YYYYMM);
        }
    }
    public class CardPndngDtlsInqRs : EsbNonT24CommonRs {
        public IEnumerable< CardPndngDtlsInqCardPndngDtlsInqRec >CardPndngDtlsInqRec { get; set; }
    }
    public class CardPndngDtlsInqCardPndngDtlsInqRec {
        public string TxnType { get; set; }
        public string TxnDate { get; set; }
        public string PostDate { get; set; }
        public string TxnCtt { get; set; }
        public string TxnAmt { get; set; }
        public string CntryCode { get; set; }
        public string AmtCcy { get; set; }
        public string FCYAmt { get; set; }
        public string XchagDate { get; set; }
    }
}
