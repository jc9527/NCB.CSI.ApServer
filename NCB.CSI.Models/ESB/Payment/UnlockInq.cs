using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Payment {
    [Validator(typeof(UnlockInqRqValidator))]
    public class UnlockInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string StartTxnDate { get; set; }
        public string EndTxnDate { get; set; }
    }

    public class UnlockInqRqValidator : AbstractValidator<UnlockInqRq> {
        public UnlockInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CardNo));
            RuleFor(x => x.StartTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class UnlockInqRs : EsbNonT24CommonRs {
        public UnlockInqCardNoRec CardNoRec { get; set; }
        public UnlockInqControlRec ControlRec { get; set; }
    }

    public class UnlockInqCardNoRec {
        public string CardNo { get; set; }
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string AuthKey { get; set; }
        public string AmtCcy { get; set; }
        public string TxnAmt { get; set; }
        public string BlkAmt { get; set; }
        public string LockSeqNo { get; set; }
        public string MrchId { get; set; }
    }

    public class UnlockInqControlRec {
        public int CurPage { get; set; }
        public int NoOfCurPage { get; set; }
        public int TtlPageNo { get; set; }
        public int NoOfRec { get; set; }
    }
}
