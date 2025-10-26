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
    [Validator(typeof(DbCardLmtInqRqValidator))]
    public class DbCardLmtInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class DbCardLmtInqRqValidator : AbstractValidator<DbCardLmtInqRq> {
        public DbCardLmtInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class DbCardLmtInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardLmtInqCardLmtRec> CardLmtRec { get; set; }
        public DbCardLmtInqControlRec ControlRec { get; set; }
    }

    public class DbCardLmtInqCardLmtRec {
        public string CardNo { get; set; }
        public string DbAcctNo { get; set; }
        public string CustPermId { get; set; }
        public string CardAtt { get; set; }
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
        public string UpdDate { get; set; }
        public string UpdTime { get; set; }
        public string UpdtUserId { get; set; }
        public string SrcCode { get; set; }
        public string AccumDayLmt { get; set; }
        public string AccumMnthLmt { get; set; }
        public string AvailDayLmt { get; set; }
        public string AvailMnthLmt { get; set; }
    }

    public class DbCardLmtInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}


