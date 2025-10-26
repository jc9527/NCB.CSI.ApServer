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
    [Validator(typeof(DbCardResndAppntInqRqValidator))]
    public class DbCardResndAppntInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string ResndAppntType { get; set; }
    }

    public class DbCardResndAppntInqRqValidator : AbstractValidator<DbCardResndAppntInqRq> {
        public DbCardResndAppntInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
            RuleFor(x => x.ResndAppntType).NotEmpty();
        }
    }

    public class DbCardResndAppntInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardResndAppntInqCardNoRec> CardNoRec { get; set; }
        public DbCardResndAppntInqControlRec ControlRec { get; set; }
    }

    public class DbCardResndAppntInqCardNoRec {
        public string CardNo { get; set; }
        public string CustChnName { get; set; }
        public string NewEndDate { get; set; }
        public string ToCMSFlg { get; set; }
        public DbCardResndAppntInqExpAppntInfo ExpAppntInfo { get; set; }
        public DbCardResndAppntInqResndAppntInfo ResndAppntInfo { get; set; }
    }

    public class DbCardResndAppntInqExpAppntInfo {
        public string ExpAppntRsnCode { get; set; }
        public string ExpAppntFlg { get; set; }
        public string ExpUpdtDate { get; set; }
    }

    public class DbCardResndAppntInqResndAppntInfo {
        public string ResndRsn { get; set; }
        public string ResndStat { get; set; }
        public string ResndDate { get; set; }
    }

    public class DbCardResndAppntInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
