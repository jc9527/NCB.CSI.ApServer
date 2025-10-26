using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(TxnLmtListInqRqValidator))]
    public class TxnLmtListInqRq : EsbInqCommonRq {
        public string AcctNo { get; set; }
    }

    public class TxnLmtListInqRqValidator : AbstractValidator<TxnLmtListInqRq> {
        public TxnLmtListInqRqValidator() {
            RuleFor(x => x.AcctNo).NotEmpty();
        }
    }

    public class TxnLmtListInqRs : EsbT24InqCommonRs {
        public IEnumerable<TxnLmtListInqTxnRec> TxnRec { get; set; }
    }

    public class TxnLmtListInqTxnRec {
        public IEnumerable<TxnLmtListInqTxnLmtRec> TxnLmtRec { get; set; }
    }

    public class TxnLmtListInqTxnLmtRec {
        public string AcctNo { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string DayLmt { get; set; }
        public string DayLmtUsed { get; set; }
        public string MnthLmt { get; set; }
        public string MnthLmtUsed { get; set; }
    }
}
