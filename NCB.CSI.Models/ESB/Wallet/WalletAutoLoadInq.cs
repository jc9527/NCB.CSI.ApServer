using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Wallet {
    [Validator(typeof(WalletAutoLoadInqRqValidator))]
    public class WalletAutoLoadInqRq : EsbDebitCardInqCommonRq {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        public string WalletNo { get; set; }
        public string StartTxnDate { get; set; }
        public string EndTxnDate { get; set; }
        public string WalletCardType { get; set; }
    }
    public class WalletAutoLoadInqRqValidator : AbstractValidator<WalletAutoLoadInqRq> {
        public WalletAutoLoadInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().When(x => string.IsNullOrEmpty(x.CardNo) && string.IsNullOrEmpty(x.WalletNo));
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrEmpty(x.CustPermId) && string.IsNullOrEmpty(x.WalletNo));
            RuleFor(x => x.WalletNo).NotEmpty().When(x => string.IsNullOrEmpty(x.CustPermId) && string.IsNullOrEmpty(x.CardNo));
            RuleFor(x => x.StartTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.WalletCardType).NotEmpty();
        }
    }
    public class WalletAutoLoadInqRs : EsbNonT24CommonRs {
        public IEnumerable<WalletAutoLoadInqWalletAutoLoadRec> WalletAutoLoadRec { get; set; }
        public WalletAutoLoadInqControlRec ControlRec { get; set; }
    }
    public class WalletAutoLoadInqWalletAutoLoadRec {
        public string WalletNo { get; set; }
        public string WalletChnName { get; set; }
        public string AmtCcy { get; set; }
        public string WalletTxnDate { get; set; }
        public string WalletTxnTime { get; set; }
        public string WalletEquipId { get; set; }
        public string WalletPrtnr { get; set; }
        public string WalletPrtnrLoc { get; set; }
        public string WalletTxnAmt { get; set; }
        public string WalletValue { get; set; }
    }
    public class WalletAutoLoadInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
