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
    [Validator(typeof(DbCardFeeInqRqValidator))]
    public class DbCardFeeInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class DbCardFeeInqRqValidator : AbstractValidator<DbCardFeeInqRq> {
        public DbCardFeeInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class DbCardFeeInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardFeeInqBillNoInfo> BillNoInfo { get; set; }
        public DbCardFeeInqControlRec ControlRec { get; set; }
    }

    public class DbCardFeeInqBillNoInfo {
        public string CardNo { get; set; }
        public string TxnCode { get; set; }
        public string AmtCcy { get; set; }
        public string TWDAmt { get; set; }
        public string TxnDate { get; set; }
        public string BillDesc { get; set; }
    }

    public class DbCardFeeInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
