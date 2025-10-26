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
    [Validator(typeof(BankCardAppRqValidator))]
    public class BankCardAppRq : EsbRqServiceBody {
        public string CIFNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string CustChnName { get; set; }
        public string CustEngName { get; set; }
        public string BirthDay { get; set; }
        public string MobNo { get; set; }
        public string AddrZip { get; set; }
        public string MailAddr1 { get; set; }
        public string MailAddr2 { get; set; }
        public string CardType { get; set; }
        public string DayLmt { get; set; }
        public string MnthLmt { get; set; }
        public string NonRsrvdFundXfer { get; set; }
        public string XbrdrWdl { get; set; }
        public string SmartPay { get; set; }
        public string DlvrMthd { get; set; }
        public string DlvrBrch { get; set; }
        [LogItem("AccountNo")]
        public string DbAcctNo { get; set; }
        public string HCE { get; set; }
        public string SMSFlg { get; set; }
        public string PushAppFlg { get; set; }
        public string eMailFlg { get; set; }
        public string SMSAmt { get; set; }
        public string eMailAddr { get; set; }
        public string EmrgIssCardFlg { get; set; }
        public string DsgntCardNo { get; set; }
        public string CardNo { get; set; }
        public string ImgId { get; set; }
        public IEnumerable<BankCardAppDbAcctInfo> DbAcctInfo { get; set; }
        public IEnumerable<BankCardAppCrBankInfo> CrBankInfo { get; set; }
        public string ChargeFlg { get; set; }
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
    public class BankCardAppDbAcctInfo {
        public string DbAcctNo { get; set; }
    }
    public class BankCardAppCrBankInfo {
        public string CrBankId { get; set; }
        public string CrAcctNo { get; set; }
    }
    public class BankCardAppRqValidator : AbstractValidator<BankCardAppRq> {
        public BankCardAppRqValidator() {
            RuleFor(x => x.CIFNo).NotEmpty();
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.CustChnName).NotEmpty();
            RuleFor(x => x.CustEngName).NotEmpty();
            RuleFor(x => x.BirthDay).NotEmpty().Matches(RegExConst.YYYYslashMMslashDD);
            RuleFor(x => x.MobNo).NotEmpty();
            RuleFor(x => x.AddrZip).NotEmpty();
            RuleFor(x => x.MailAddr1).NotEmpty();
            RuleFor(x => x.MailAddr2).NotEmpty();
            RuleFor(x => x.CardType).NotEmpty();
            RuleFor(x => x.DayLmt).NotEmpty();
            RuleFor(x => x.MnthLmt).NotEmpty();
            RuleFor(x => x.NonRsrvdFundXfer).NotEmpty();
            RuleFor(x => x.XbrdrWdl).NotEmpty();
            RuleFor(x => x.SmartPay).NotEmpty();
            RuleFor(x => x.DlvrMthd).NotEmpty();
            RuleFor(x => x.DbAcctNo).NotEmpty();
            RuleFor(x => x.HCE).NotEmpty();
            RuleFor(x => x.SMSFlg).NotEmpty();
            RuleFor(x => x.PushAppFlg).NotEmpty();
            RuleFor(x => x.eMailFlg).NotEmpty();
            RuleFor(x => x.SMSAmt).NotEmpty();
            RuleFor(x => x.eMailAddr).NotEmpty();
            RuleFor(x => x.EmrgIssCardFlg).NotEmpty();
            RuleFor(x => x.DsgntCardNo).NotEmpty();
            RuleFor(x => x.ImgId).NotEmpty();
            RuleFor(x => x.CardGrade).NotEmpty();
            RuleFor(x => x.GrpCode).NotEmpty();
            RuleFor(x => x.ElekCardType).NotEmpty();
            RuleFor(x => x.Natl).NotEmpty();
        }
    }
    public class BankCardAppRs : EsbNonT24CommonRs {
    }
}
