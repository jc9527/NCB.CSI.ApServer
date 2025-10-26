using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Wallet {
    [Validator(typeof(WalletProfInqRqValidator))]
    public class WalletProfInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string WalletCardType { get; set; }
    }
    public class WalletProfInqRqValidator : AbstractValidator<WalletProfInqRq> {
        public WalletProfInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$").When(x => string.IsNullOrWhiteSpace(x.CardNo));
            RuleFor(x => x.WalletCardType).NotEmpty();
        }
    }
    public class WalletProfInqRs : EsbNonT24CommonRs {
        public IEnumerable< WalletProfInqWalletProfRec >WalletProfRec { get; set; }
        public WalletProfInqControlRec ControlRec { get; set; }
    }
    public class WalletProfInqWalletProfRec {
        public string CardNo { get; set; }
        public string WalletNo { get; set; }
        public string WalletStat { get; set; }
        public string AmtCcy { get; set; }
        public string CanDate { get; set; }
        public string CanRsn { get; set; }
        public string AutoLoadFlg { get; set; }
        public string AutoLoadDate { get; set; }
        public string AutoLoadTime { get; set; }
        public string AutoLoadUserId { get; set; }
        public string AutoLoadCanTime { get; set; }
        public string CanAutoLoadUserId { get; set; }
        public string FeeBackDate { get; set; }
        public string FeeBackTime { get; set; }
        public string FeeBackAmt { get; set; }
        public string TxnAmt { get; set; }
        public string WalletLockDate { get; set; }
        public string WalletLockTime { get; set; }
        public string WalletLockMrchName { get; set; }
        public string WalletLockAddr { get; set; }
        public string CardRtrnDate { get; set; }
        public string CardRtrnTime { get; set; }
        public string CardRtrnMrchName { get; set; }
        public string CardRtrnAddr { get; set; }
    }
    public class WalletProfInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
