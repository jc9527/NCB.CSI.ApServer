using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.PaymentOrder {
    [Validator(typeof(FiscTxnLogDtlsInqRqValidator))]
    public class FiscTxnLogDtlsInqRq : EsbRqServiceBody {
        public string TxnDate { get; set; }
        public string AcqBankId { get; set; }
        public string TxnSeqNo { get; set; }
    }

    public class FiscTxnLogDtlsInqRqValidator : AbstractValidator<FiscTxnLogDtlsInqRq> {
        public FiscTxnLogDtlsInqRqValidator() {
            RuleFor(x => x.TxnDate).NotEmpty().Matches(RegExConst.YYYY_MM_DD);
            RuleFor(x => x.AcqBankId).NotEmpty();
            RuleFor(x => x.TxnSeqNo).NotEmpty();
        }
    }

    public class FiscTxnLogDtlsInqRs : EsbNonT24CommonRs {
        public FiscTxnLogDtlsInqTxnLogDtlsRec TxnLogDtlsRec { get; set; }
    }

    public class FiscTxnLogDtlsInqTxnLogDtlsRec {
        public string AcqBankId { get; set; }
        public string TermNo { get; set; }
        public string ChanId { get; set; }
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string TxnPCode { get; set; }
        public string TxnAmt { get; set; }
        public string OrigAmt { get; set; }
        public string AmtCcy { get; set; }
        public string ForExRate { get; set; }
        public string CrAcctNo { get; set; }
        public string CrBankId { get; set; }
        public string DbCardNo { get; set; }
        public string DbAcctNo { get; set; }
        public string DbBankId { get; set; }
        public string DestBankId { get; set; }
        public string FISCDate { get; set; }
        public string TlrNo { get; set; }
        public string ATMSeqNo { get; set; }
        public string T24VerNo { get; set; }
        public string T24Memo { get; set; }
        public string HdlgChrg { get; set; }
        public string ExpDate { get; set; }
        public string TxnType { get; set; }
        public string DgtlAcctType { get; set; }
        public string AvailBal { get; set; }
        public string AcctBal { get; set; }
        public string TxnFlow { get; set; }
    }
}