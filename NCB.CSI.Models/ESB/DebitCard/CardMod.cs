using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(CardModRqValidator))]
    public class CardModRq : EsbDebitCardCommonRq {
        public string CardNo { get; set; }
        public string WalletNo { get; set; }
        public string BlkCodeFlg { get; set; }
        public string BlkCode1 { get; set; }
        public string UpdtDate { get; set; }
        public string UpdtTime { get; set; }
        public string UpdtUserID { get; set; }
        public string LostFeeFlg { get; set; }
        public string FeeCode { get; set; }
        public string FeeAmt { get; set; }
    }
    public class CardModRqValidator : AbstractValidator<CardModRq> {
        public CardModRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.BlkCodeFlg).NotEmpty();
            RuleFor(x => x.BlkCode1).NotEmpty();
            RuleFor(x => x.UpdtDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.UpdtTime).NotEmpty().Matches(RegExConst.HHNNSS); ;
            RuleFor(x => x.UpdtUserID).NotEmpty();
        }
    }
    public class CardModRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
