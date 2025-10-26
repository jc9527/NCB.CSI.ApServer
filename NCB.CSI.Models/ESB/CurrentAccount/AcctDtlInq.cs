using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;

namespace NCB.CSI.Models.ESB.CurrentAccount {
    [Validator(typeof(AcctDtlInqRqValidator))]
    public class AcctDtlInqRq : EsbInqCommonRq {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public string ArrngId { get; set; }
    }

    public class AcctDtlInqRqValidator : AbstractValidator<AcctDtlInqRq> {
        public AcctDtlInqRqValidator() {
            RuleFor(x => x.AcctNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ArrngId));
            RuleFor(x => x.ArrngId).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.AcctNo));
        }
    }

    public class AcctDtlInqRs : EsbT24InqCommonRs {
        public IEnumerable<AcctDtlInqAcctRec> AcctRec { get; set; }
    }

    public class AcctDtlInqAcctRec {
        public string ArrngId { get; set; }
        public string AcctNo { get; set; }
        public IEnumerable<AcctDtlInqSavAcctRec> SavAcctRec { get; set; }
    }

    public class AcctDtlInqSavAcctRec {
        public string CustPermId { get; set; }
        public string AcctTitl2 { get; set; }
        public string Ccy { get; set; }
        public string LockAmt { get; set; }
        public string WorkBal { get; set; }
        public string WdlLmt { get; set; }
        public string CIFNo { get; set; }
        public IEnumerable<AcctDtlInqCustChnNameInfo> CustChnNameInfo { get; set; }
        public string EmplNo { get; set; }
        public string LPayRollCode { get; set; }
        public string ScrtAcctFlg { get; set; }
        public string CtrctType { get; set; }
        public string CtrctVer { get; set; }
        public string AppntDate { get; set; }
        public IEnumerable<AcctDtlInqAcctOpnPurpRec> AcctOpnPurpRec { get; set; }
        public string PktAcctNo { get; set; }
        public string AcctNo { get; set; }
        public string CampId { get; set; }
        public string CampExpDate { get; set; }
        public string AcctClsDate { get; set; }
        public string LoanLmtTtl { get; set; }
        public string ProdName { get; set; }
        public string DgtlLvl { get; set; }
        public string LmtRefNo { get; set; }
        public string LmtRefId { get; set; }
        public string LmtAmt { get; set; }
        public string AvailLmtAmt { get; set; }
        public string AcctOpnDate { get; set; }
        public IEnumerable<EsbPostRstrctRec> PostRstrctRec { get; set; }
        public IEnumerable<AcctDtlInqIntrstRec> IntrstRec { get; set; }
        public string MinAccruAmt { get; set; }
        public string MaxAccruAmt { get; set; }
    }

    public class AcctDtlInqCustChnNameInfo {
        public string CustChnName { get; set; }
    }

    public class AcctDtlInqAcctOpnPurpRec {
        public string AcctOpnPurp { get; set; }
    }

    public class AcctDtlInqIntrstRec {
        public string IntrstName { get; set; }
        public string IntrstRate { get; set; }
        public string MrgnRateAdd { get; set; }
    }
}