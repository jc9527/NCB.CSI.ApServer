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
    [Validator(typeof(DbCardTxnFnctInqRqValidator))]
    public class DbCardTxnFnctInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class DbCardTxnFnctInqRqValidator : AbstractValidator<DbCardTxnFnctInqRq> {
        public DbCardTxnFnctInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class DbCardTxnFnctInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardTxnFnctInqCardNoRec> CardNoRec { get; set; }
        public DbCardTxnFnctInqControlRec ControlRec { get; set; }
    }

    public class DbCardTxnFnctInqCardNoRec {
        public string CardNo { get; set; }
        public string LcyTxnFlg { get; set; }
        public string XbrdrTxnFlg { get; set; }
        public string XbrdrWdlFlg { get; set; }
        public string ElekCardAutoLoadFlg { get; set; }
        public string ElekCardFlg { get; set; }
    }

    public class DbCardTxnFnctInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
