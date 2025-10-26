using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(AcctClsInqRqValidator))]
    public class AcctClsInqRq : EsbInqCommonRq {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public string ArrngId { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class AcctClsInqRqValidator : AbstractValidator<AcctClsInqRq> {
        public AcctClsInqRqValidator() {
            RuleFor(x => x.AcctNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ArrngId) && string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.ArrngId).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.AcctNo) && string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.AcctNo) && string.IsNullOrWhiteSpace(x.ArrngId));
        }
    }

    public class AcctClsInqRs : EsbT24InqCommonRs {
        public IEnumerable<AcctClsInqCustInfo> CustInfo { get; set; }
    }

    public class AcctClsInqCustInfo {
        public string CustPermId { get; set; }
        public string AcctNo { get; set; }
        public string ArrngId { get; set; }
        public IEnumerable<AcctClsInqAcctRec> AcctRec { get; set; }
    }

    public class AcctClsInqAcctRec {
        public string AcctTitl2 { get; set; }
        public string Ccy { get; set; }
        public string WorkBal { get; set; }
        public string AvailBal { get; set; }
        public string CIFNo { get; set; }
        public string ProdName { get; set; }
        public string AvailLmtAmt { get; set; }
        public string AcctOpnDate { get; set; }
        public IEnumerable<AcctClsInqPostRstrctRec> PostRstrctRec { get; set; }
        public string AccrdInstrtAmt { get; set; }
        public string TaxAmt { get; set; }
        public string TWDAmt { get; set; }
        public string OrigAmt { get; set; }
    }

    public class AcctClsInqPostRstrctRec {
        public string PostRstrctStatus { get; set; }
    }
}
