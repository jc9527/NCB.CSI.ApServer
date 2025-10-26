using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.PaymentOrder {
    [Validator(typeof(PmtInqRqValidator))]
    public class PmtInqRq : EsbRqServiceBody {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        [LogItem("AccountNo")]
        public string PayerAcctId { get; set; }
        public string PayeePermId { get; set; }
        public string NextInqKeyId { get; set; }
    }
    public class PmtInqRqValidator : AbstractValidator<PmtInqRq> {
        public PmtInqRqValidator() {
            RuleFor(x => x.StartDate).NotEmpty().Matches(@"^[12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$");
            RuleFor(x => x.EndDate).NotEmpty().Matches(@"^[12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$");
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$").When(x => string.IsNullOrEmpty(x.PayeePermId));
            RuleFor(x => x.PayerAcctId).NotEmpty().When(x => string.IsNullOrEmpty(x.CustPermId));
        }
    }
    public class PmtInqRs : EsbNonT24CommonRs {
        public PmtInqPmtInqRec PmtInqRec { get; set; }
        public PmtInqControlRec ControlRec { get; set; }
    }
    public class PmtInqPmtInqRec {
        public string TxNo { get; set; }
        public string ChanId { get; set; }
        public string CustPermId { get; set; }
        public string PayerAcctId { get; set; }
        public string PayerBankId { get; set; }
        public string PrcDate { get; set; }
        public string PostDate { get; set; }
        public string CurAmt { get; set; }
        public string HdlgChrg { get; set; }
        public string AvailBal { get; set; }
        public string AcctBal { get; set; }
        public string DbMemo1 { get; set; }
        public string DbMemo2 { get; set; }
        public string DbMemo3 { get; set; }
        public string FiscMemo { get; set; }
        public string PayeePermId { get; set; }
        public string PayeeAcctId { get; set; }
        public string PayeeBankId { get; set; }
        public string CrMemo1 { get; set; }
        public string CrMemo2 { get; set; }
        public string FISCTxnNo { get; set; }
        public string TxnFlow { get; set; }
    }
    public class PmtInqControlRec {
        public string EOFFlg { get; set; }
        public string NextInqKeyId { get; set; }
    }
}
