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
    [Validator(typeof(DbCardInstlmtInqRqValidator))]
    public class DbCardInstlmtInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        public string StartCfgDate { get; set; }
        public string EndCfgDate { get; set; }
    }

    public class DbCardInstlmtInqRqValidator : AbstractValidator<DbCardInstlmtInqRq> {
        public DbCardInstlmtInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.StartCfgDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndCfgDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class DbCardInstlmtInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardInstlmtInqCardLmtRec> CardLmtRec { get; set; }
        public DbCardInstlmtInqControlRec ControlRec { get; set; }
    }

    public class DbCardInstlmtInqCardLmtRec {
        public string DbAcctNo { get; set; }
        public string CustPermId { get; set; }
        public string AmtCcy { get; set; }
        public string DayLmt { get; set; }
        public string MnthLmt { get; set; }
        public string AutoLoadLmt { get; set; }
        public string TempDDLmt { get; set; }
        public string StartTempDDLmtDate { get; set; }
        public string EndTempDDLmtDate { get; set; }
        public string TempMMLmt { get; set; }
        public string StartTempMMLmtDate { get; set; }
        public string EndTempMMLmtDate { get; set; }
        public string CfgDate { get; set; }
        public string CfgTime { get; set; }
        public string CfgUserId { get; set; }
    }

    public class DbCardInstlmtInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
