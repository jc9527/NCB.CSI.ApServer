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
    [Validator(typeof(DbCardLockAcctInqRqValidator))]
    public class DbCardLockAcctInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class DbCardLockAcctInqRqValidator : AbstractValidator<DbCardLockAcctInqRq> {
        public DbCardLockAcctInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class DbCardLockAcctInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardLockAcctInqCardTxnRec> CardTxnRec { get; set; }
        public DbCardLockAcctInqControlRec ControlRec { get; set; }
    }

    public class DbCardLockAcctInqCardTxnRec {
        public string CardNo { get; set; }
        public string AcctNo { get; set; }
        public string AcctType { get; set; }
    }

    public class DbCardLockAcctInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
