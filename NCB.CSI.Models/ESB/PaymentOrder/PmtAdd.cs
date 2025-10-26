using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.PaymentOrder {
    [Validator(typeof(PmtAddRqValidator))]
    public class PmtAddRq : EsbRqServiceBody {
        public string TxNo { get; set; }
        public string ChanId { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string CustChnName { get; set; }
        public string PayerAcctId { get; set; }
        public string PrcDate { get; set; }
        public string CurAmt { get; set; }
        public string CustPayeeId { get; set; }
        public string PayeeAcctId { get; set; }
        public string PayeeName { get; set; }
        public string PayeeBankId { get; set; }
        public string GPS { get; set; }
        public string TxnNo { get; set; }
        public string ChanTxnNo { get; set; }
        public string MobLang { get; set; }
        public string DgtlAcctType { get; set; }
        public string IPAddr { get; set; }
        public string IMEI { get; set; }
        public string FISCMemo { get; set; }
        public string Memo1 { get; set; }
        public string Memo2 { get; set; }
    }
    public class PmtAddRqValidator : AbstractValidator<PmtAddRq> {
        public PmtAddRqValidator() {
            RuleFor(x => x.TxNo).NotEmpty();
            RuleFor(x => x.ChanId).NotEmpty();
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$");
            RuleFor(x => x.PayerAcctId).NotEmpty();
            RuleFor(x => x.PrcDate).NotEmpty().Matches(@"^[12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$");
            RuleFor(x => x.CurAmt).NotEmpty();
            RuleFor(x => x.CustPayeeId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$");
            RuleFor(x => x.PayeeAcctId).NotEmpty();
            RuleFor(x => x.PayeeBankId).NotEmpty();
            RuleFor(x => x.GPS).NotEmpty();
            RuleFor(x => x.TxnNo).NotEmpty();
            RuleFor(x => x.ChanTxnNo).NotEmpty();
            RuleFor(x => x.MobLang).NotEmpty();
            RuleFor(x => x.DgtlAcctType).NotEmpty();
            RuleFor(x => x.IPAddr).NotEmpty();
            RuleFor(x => x.IMEI).NotEmpty();
            RuleFor(x => x.FISCMemo).NotEmpty();
            RuleFor(x => x.Memo1).NotEmpty();
            RuleFor(x => x.Memo2).NotEmpty();
        }
    }
    public class PmtAddRs : EsbNonT24CommonRs {
        public PmtAddPmtAddInfo PmtAddInfo { get; set; }
    }
    public class PmtAddPmtAddInfo {
        public string TxNo { get; set; }
        public string PostDate { get; set; }
        public string CurAmt { get; set; }
        public string HdlgChrg { get; set; }
        public string AvailBal { get; set; }
        public string AcctBal { get; set; }
        public string FISCTxnNo { get; set; }
        public string FISCRtrnCode { get; set; }
    }
}
