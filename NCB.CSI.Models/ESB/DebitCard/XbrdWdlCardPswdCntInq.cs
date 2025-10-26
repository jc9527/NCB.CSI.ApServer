using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(XbrdWdlCardPswdCntInqRqValidator))]
    public class XbrdWdlCardPswdCntInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class XbrdWdlCardPswdCntInqRqValidator : AbstractValidator<XbrdWdlCardPswdCntInqRq> {
        public XbrdWdlCardPswdCntInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
        }
    }

    public class XbrdWdlCardPswdCntInqRs : EsbNonT24CommonRs {
        public IEnumerable<XbrdWdlCardPswdCntInqCardNoRec> CardNoRec { get; set; }
        public XbrdWdlCardPswdCntInqControlRec ControlRec { get; set; }
    }

    public class XbrdWdlCardPswdCntInqCardNoRec {
        public string CardNo { get; set; }
        [JsonConverter(typeof(SecureStringConverter))]
        public SecureString PswdErrTims { get; set; }
    }

    public class XbrdWdlCardPswdCntInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
