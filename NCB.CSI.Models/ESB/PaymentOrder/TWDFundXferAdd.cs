using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.PaymentOrder {
    [Validator(typeof(TWDFundXferAddRqValidator))]
    public class TWDFundXferAddRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string ChanId { get; set; }
        public string DbBankId { get; set; }
        [LogItem("AccountNo")]
        public string DbAcctNo { get; set; }
        public string DbAmt { get; set; }
        public string CrBankId { get; set; }
        public string CrAcctNo { get; set; }
        public string TermChkCode { get; set; }
        public string ICCMemo { get; set; }
        public string ICCSeqNo { get; set; }
        public string ICCTAC { get; set; }
        public string SameIdFlg { get; set; }
        public string TxnType { get; set; }
        public string DgtlAcctType { get; set; }
        public string TxnNo { get; set; }
        public string ChanTxnNo { get; set; }
        public string GPS { get; set; }
        public string IPAddr { get; set; }
        public string MobLang { get; set; }
        public string IMEI { get; set; }
        public string DbRefData { get; set; }
        public string DbMemo1 { get; set; }
        public string DbMemo2 { get; set; }
        public string DbMemo3 { get; set; }
        public string CrRefData { get; set; }
        public string CrMemo1 { get; set; }
        public string CrMemo2 { get; set; }
        public string CrMemo3 { get; set; }
        public string Memo { get; set; }

    }
    public class TWDFundXferAddRqValidator : AbstractValidator<TWDFundXferAddRq> {
        public TWDFundXferAddRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$");
            RuleFor(x => x.ChanId).NotEmpty();
            RuleFor(x => x.DbAcctNo).NotEmpty();
            RuleFor(x => x.DbAmt).NotEmpty();
            RuleFor(x => x.CrBankId).NotEmpty();
            RuleFor(x => x.CrAcctNo).NotEmpty();
            RuleFor(x => x.TxnType).NotEmpty();
            RuleFor(x => x.DgtlAcctType).NotEmpty();
            RuleFor(x => x.TxnNo).NotEmpty();
            RuleFor(x => x.ChanTxnNo).NotEmpty();
        }
    }
    public class TWDFundXferAddRs : EsbNonT24CommonRs {
        public TWDFundXferAddFundXferInfo FundXferInfo { get; set; }
    }
    public class TWDFundXferAddFundXferInfo {
        public string TxnDate { get; set; }
        public string HdlgChrg { get; set; }
        public string AvailBal { get; set; }
        public string AcctBal { get; set; }
        public string AmtCcy { get; set; }
        public string FISCTxnNo { get; set; }
        public string FISCRtrnCode { get; set; }
    }
}
