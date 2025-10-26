using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(DbCardLmtModRqValidator))]
    public class DbCardLmtModRq : EsbDebitCardCommonRq {
        public string CardNo { get; set; }
        public string DayLmt { get; set; }
        public string MnthLmt { get; set; }
        public string AutoLoadLmt { get; set; }
        public string TempDDLmt { get; set; }
        public string StartTempDDLmtDate { get; set; }
        public string EndTempDDLmtDate { get; set; }
        public string TempMMLmt { get; set; }
        public string StartTempMMLmtDate { get; set; }
        public string EndTempMMLmtDate { get; set; }
        public string UpdDate { get; set; }
        public string UpdTime { get; set; }
        public string UpdtUserId { get; set; }

    }
    public class DbCardLmtModRqValidator : AbstractValidator<DbCardLmtModRq> {
        public DbCardLmtModRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.DayLmt).NotEmpty();
            RuleFor(x => x.MnthLmt).NotEmpty();
            RuleFor(x => x.UpdDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.UpdTime).NotEmpty().Matches(RegExConst.HHNNSS);
            RuleFor(x => x.UpdtUserId).NotEmpty();
        }
    }
    public class DbCardLmtModRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
