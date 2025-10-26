using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(DbCardTxnAcidntDtlsInqRqValidator))]
    public class DbCardTxnAcidntDtlsInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string StartTxnDate { get; set; }
        public string EndTxnDate { get; set; }
    }

    public class DbCardTxnAcidntDtlsInqRqValidator : AbstractValidator<DbCardTxnAcidntDtlsInqRq> {
        public DbCardTxnAcidntDtlsInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
            RuleFor(x => x.StartTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class DbCardTxnAcidntDtlsInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardTxnAcidntDtlsInqCardNoRec> CardNoRec { get; set; }
        public DbCardTxnAcidntDtlsInqControlRec ControlRec { get; set; }
    }

    public class DbCardTxnAcidntDtlsInqCardNoRec {
        public string CardNo { get; set; }
        public string AmtCcy { get; set; }
        public string TxnCode { get; set; }
        public string PostDate { get; set; }
        public string TxnDate { get; set; }
        public string LoanBal { get; set; }
        public string AvailBal { get; set; }
        public string BillNo { get; set; }
    }

    public class DbCardTxnAcidntDtlsInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
