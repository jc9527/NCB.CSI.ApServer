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

namespace NCB.CSI.Models.ESB.BankCard {
    [Validator(typeof(BankCardAppStatInqRqValidator))]
    public class BankCardAppStatInqRq : EsbBankCardInqCommonRq {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class BankCardAppStatInqRqValidator : AbstractValidator<BankCardAppStatInqRq> {
        public BankCardAppStatInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class BankCardAppStatInqRs : EsbNonT24InqCommonRs {
        public IEnumerable<BankCardAppStatInqCardStatRec> CardStatRec { get; set; }
    }

    public class BankCardAppStatInqCardStatRec {
        public string CustPermId { get; set; }
        public string CustChnName { get; set; }
        public string CustEngName { get; set; }
        public string BirthDay { get; set; }
        public string CardNo { get; set; }
        public string WalletNo { get; set; }
        public string DbAcctNo { get; set; }
        public string CardType { get; set; }
        public string CardTypeName { get; set; }
        public string CardAttr { get; set; }
        public string CardAttrName { get; set; }
        public string CardStatCode { get; set; }
        public string CardStatName { get; set; }
        public string DlvrMthd { get; set; }
        public string DlvrMthdName { get; set; }
        public string DlvrBrch { get; set; }
        public string DlvrBrchName { get; set; }
        public string AppDate { get; set; }
        public string VldYearMnth { get; set; }
        public string ExpYearMnth { get; set; }
        public string RgstrDate { get; set; }
        public string RgstrNo { get; set; }
        public string EffDate { get; set; }
        public string MakeDate { get; set; }
        public string ImgId { get; set; }
        public string ElekCardType { get; set; }
        public string ImgFlg { get; set; }
        public string CardFace { get; set; }
        public string CardFaceName { get; set; }
        public string CardGrade { get; set; }
        public string GrpCode { get; set; }
    }
}
