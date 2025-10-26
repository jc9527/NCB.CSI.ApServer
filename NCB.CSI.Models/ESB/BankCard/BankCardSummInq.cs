using Devpro.Shared.Attributies;
using Devpro.Shared.Extensions;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardSummInqRqValidator))]
    public class BankCardSummInqRq : EsbBankCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class BankCardSummInqRqValidator : AbstractValidator<BankCardSummInqRq> {
        public BankCardSummInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class BankCardSummInqRs : EsbNonT24InqCommonRs {
        public IEnumerable<BankCardSummInqBankCardRec> BankCardRec { get; set; }
    }

    public class BankCardSummInqBankCardRec {
        public string CIFNo { get; set; }
        public string CustPermId { get; set; }
        public string CustChnName { get; set; }
        public string CustEngName { get; set; }
        public string BirthDay { get; set; }
        public string MobNo { get; set; }
        public string AddrZip { get; set; }
        public string MailAddr1 { get; set; }
        public string MailAddr2 { get; set; }
        public string CardType { get; set; }
        public string CardTypeName { get; set; }
        public string CardFace { get; set; }
        public string CardFaceName { get; set; }
        public string AmtCcy { get; set; }
        public string DayLmt { get; set; }
        public string MnthLmt { get; set; }
        public string NPDFundXfer { get; set; }
        public string XbrdrWdl { get; set; }
        public string SmartPayFlg { get; set; }
        public string DlvrMthd { get; set; }
        public string DlvrMthdName { get; set; }
        public string DlvrBrch { get; set; }
        public string DlvrBrchName { get; set; }
        public string DbAcctNo { get; set; }
        public string HCE { get; set; }
        public string SMSFlg { get; set; }
        public string PushAppFlg { get; set; }
        public string eMailFlg { get; set; }
        public string SMSAmt { get; set; }
        public string eMailAddr { get; set; }
        public IEnumerable<BankCardSummInqDbAcctInfo> DbAcctInfo { get; set; }
        public IEnumerable<BankCardSummInqCrBankInfo> CrBankInfo { get; set; }
        public string CardNo { get; set; }
        public string WalletNo { get; set; }
        public string CardStat { get; set; }
        public string CardIssueStat { get; set; }
        public string EffDateFrom { get; set; }
        public string VldDate { get; set; }
        public string AppDate { get; set; }
        public string RegrDate { get; set; }
        public string RegrNo { get; set; }
        public string CardAttr { get; set; }
        public string CardAttrName { get; set; }
        public string RelnCode { get; set; }
        public string RelnCodeName { get; set; }
        public string PriCIFNo { get; set; }
        public string PriCustId { get; set; }
        public string PriCardNo { get; set; }
        public string SrcId { get; set; }
        public string TlrId { get; set; }
        public string PriBirthDay { get; set; }
        public string PriMobNo { get; set; }
        public string CardLmtShrtAmt { get; set; }
        public string EffDate { get; set; }
        public string MakeDate { get; set; }
        public string ImgId { get; set; }
        public string ElekCardType { get; set; }
        public string ImgFlg { get; set; }
        public string CardGrade { get; set; }
        public string GrpCode { get; set; }

    }

    public class BankCardSummInqDbAcctInfo {
        public string DbAcctNo { get; set; }
    }

    public class BankCardSummInqCrBankInfo {
        public string CrBankId { get; set; }
        public string CrAcctNo { get; set; }
    }
}
