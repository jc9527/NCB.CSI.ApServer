using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.PaymentOrder {
    [Validator(typeof(FiscTxnLogSummInqRqValidator))]
    public class FiscTxnLogSummInqRq : EsbRqServiceBody {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string AcqBankId { get; set; }
        public string TxnSeqNo { get; set; }
        public string DbCardNo { get; set; }
        [LogItem("AccountNo")]
        public string DbAcctNo { get; set; }
        public string CrAcctNo { get; set; }
        public bool FrstInqFlg { get; set; }
        public string NoOfPage { get; set; }
        public string NextInqKeyId { get; set; }
    }

    public class FiscTxnLogSummInqRqValidator : AbstractValidator<FiscTxnLogSummInqRq> {
        public FiscTxnLogSummInqRqValidator() {
            RuleFor(x => x.StartDate).NotEmpty().Matches(RegExConst.YYYY_MM_DD);
            RuleFor(x => x.EndDate).NotEmpty().Matches(RegExConst.YYYY_MM_DD);
            RuleFor(x => x.NoOfPage).NotEmpty();
            RuleFor(x => x.NextInqKeyId).NotEmpty();
        }
    }

    public class FiscTxnLogSummInqRs : EsbNonT24CommonRs {
        public IEnumerable<FiscTxnLogSummInqTxnLogRec> TxnLogRec { get; set; }
        public FiscTxnLogSummInqControlRec ControlRec { get; set; }
    }

    public class FiscTxnLogSummInqTxnLogRec {
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string AcqBankId { get; set; }
        public string TxnSeqNo { get; set; }
        public string TxnPCode { get; set; }
        public string DbAmt { get; set; }
        public string AmtCcy { get; set; }
        public string DbAcctNo { get; set; }
        public string CardNo { get; set; }
    }

    public class FiscTxnLogSummInqControlRec {
        public string EOFFlg { get; set; }
        public string NextInqKeyId { get; set; }
    }

}
