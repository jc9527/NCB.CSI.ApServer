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
    [Validator(typeof(DbCardFnctInqRqValidator))]
    public class DbCardFnctInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class DbCardFnctInqRqValidator : AbstractValidator<DbCardFnctInqRq> {
        public DbCardFnctInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class DbCardFnctInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardFnctInqCardBlkRec> CardBlkRec { get; set; }
        public DbCardFnctInqControlRec ControlRec { get; set; }
    }

    public class DbCardFnctInqCardBlkRec {
        public IEnumerable<DbCardFnctInqCardBlkinfo> CardBlkinfo { get; set; }
        public string CardNo { get; set; }
        public string CardName { get; set; }
        public string CustPermId { get; set; }
        public string CardType { get; set; }
        public string CardAtt { get; set; }
        public string RelnCode { get; set; }
        public string ExpYearMnth { get; set; }
        public string CntlrId { get; set; }
        public string Memo { get; set; }
    }

    public class DbCardFnctInqCardBlkinfo {
        public string BlkSrcId { get; set; }
        public string BlkCode { get; set; }
        public string BlkDate { get; set; }
        public string BlkTime { get; set; }
    }

    public class DbCardFnctInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
