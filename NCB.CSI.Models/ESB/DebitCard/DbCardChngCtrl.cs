using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {

    [Validator(typeof(DbCardChngCtrlRqValidator))]
    public class DbCardChngCtrlRq : EsbDebitCardCommonRq {
        public string CardNo { get; set; }
        public string BlkSrcId { get; set; }
        public string BlkCode { get; set; }
        public string BlkDate { get; set; }
        public string BlkTime { get; set; }
        public string CntlrId { get; set; }
        public string Memo { get; set; }
    }
    public class DbCardChngCtrlRqValidator : AbstractValidator<DbCardChngCtrlRq> {
        public DbCardChngCtrlRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.BlkSrcId).NotEmpty();
            RuleFor(x => x.BlkCode).NotNull();
            RuleFor(x => x.BlkDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.BlkTime).NotEmpty().Matches(RegExConst.HHNNSS);
            RuleFor(x => x.CntlrId).NotEmpty();
        }
    }
    public class DbCardChngCtrlRs : EsbNonT24CommonRs {
    }
}
