using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(DbCardTxnFnctModRqValidator))]
    public class DbCardTxnFnctModRq : EsbDebitCardCommonRq {
        public string CardNo { get; set; }
        public string LcyTxnFlg { get; set; }
        public string XbrdrTxnFlg { get; set; }
        public string XbrdrWdlFlg { get; set; }
        public string ElekCardAutoLoadFlg { get; set; }
        public string ElekCardFlg { get; set; }
        public string UpdtUserID { get; set; }
    }
    public class DbCardTxnFnctModRqValidator : AbstractValidator<DbCardTxnFnctModRq> {
        public DbCardTxnFnctModRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            //RuleFor(x => x.LcyTxnFlg).NotEmpty();
            //RuleFor(x => x.XbrdrTxnFlg).NotEmpty();
            //RuleFor(x => x.XbrdrWdlFlg).NotEmpty();
            //RuleFor(x => x.ElekCardAutoLoadFlg).NotEmpty();
            //RuleFor(x => x.ElekCardFlg).NotEmpty();
            RuleFor(x => x.UpdtUserID).NotEmpty();
        }
    }
    public class DbCardTxnFnctModRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }
}
