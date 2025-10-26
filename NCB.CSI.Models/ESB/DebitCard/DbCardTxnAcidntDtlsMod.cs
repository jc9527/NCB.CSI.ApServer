using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(DbCardTxnAcidntDtlsModRqValidator))]
    public class DbCardTxnAcidntDtlsModRq : EsbDebitCardCommonRq {
        public string BillNo { get; set; }
        public string CardNo { get; set; }
        public string AdjAmt { get; set; }
        public string ChartAcct { get; set; }
        public string AdjDesc { get; set; }
        public string UpdtUserId { get; set; }
        public string SprvsrlId { get; set; }
    }
    public class DbCardTxnAcidntDtlsModRqValidator : AbstractValidator<DbCardTxnAcidntDtlsModRq> {
        public DbCardTxnAcidntDtlsModRqValidator() {
            RuleFor(x => x.BillNo).NotEmpty();
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.AdjAmt).NotEmpty();
            RuleFor(x => x.UpdtUserId).NotEmpty();
            RuleFor(x => x.SprvsrlId).NotEmpty();
        }
    }
    public class DbCardTxnAcidntDtlsModRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
