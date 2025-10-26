using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardResndChkRqValidator))]
    public class BankCardResndChkRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        [LogItem("AccountNo")]
        public string DbAcctNo { get; set; }
        public string ResndType { get; set; }
    }
    public class BankCardResndChkRqValidator : AbstractValidator<BankCardResndChkRq> {
        public BankCardResndChkRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
        }
    }
    public class BankCardResndChkRs : EsbNonT24CommonRs {
        public BankCardResndChkPriCardResndInfo PriCardResndInfo { get; set; }
    }
    public class BankCardResndChkPriCardResndInfo {
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
        public string NonRsrvdFundXferFlg { get; set; }
        public string XbrdrWdlFlg { get; set; }
        public string SmartPayFlg { get; set; }
        public string DlvrMthd { get; set; }
        public string DlvrMthdName { get; set; }
        public string DlvrBrch { get; set; }
        public string DlvrBrchName { get; set; }
        public string DbAcctNo { get; set; }
        public string HCEFlag { get; set; }
        public string SMSFlg { get; set; }
        public string PushAppFlg { get; set; }
        public string EMailFlg { get; set; }
        public string SMSAmt { get; set; }
        public string EMailAddr { get; set; }
        public string DsgntCarFlg { get; set; }
        public string CardNo { get; set; }
        public string EffDateFrom { get; set; }
        public string EffDateTo { get; set; }
        public string CardFlg { get; set; }
        public string Img { get; set; }
        public IEnumerable<BankCardResndChkDbAcctInfo> DbAcctInfo { get; set; }
        public IEnumerable<BankCardResndChkCrAcctInfo> CrAcctInfo { get; set; }
        public string SubAcctFlg { get; set; }
        public string MainAcctPermId { get; set; }
        public string MainAcctMobNo { get; set; }
        public string AutoLoadLmt { get; set; }
        public string CardGrade { get; set; }
        public string GrpCode { get; set; }
        public string ElekCardType { get; set; }
        public string Natl { get; set; }
        public string PinYinName { get; set; }
    }
    public class BankCardResndChkDbAcctInfo {
        public string DbAcctNo { get; set; }
    }
    public class BankCardResndChkCrAcctInfo {
        public string CrBankID { get; set; }
        public string CrAcctNo { get; set; }
    }
}
