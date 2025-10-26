using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(LoanAppStatInqRqValidator))]
    public class LoanAppStatInqRq : EsbRqServiceBody {
        public string IBMBAppNo { get; set; }
        public string AppRefNo { get; set; }
    }

    public class LoanAppStatInqRqValidator : AbstractValidator<LoanAppStatInqRq> {
        public LoanAppStatInqRqValidator() {
            RuleFor(x => x.IBMBAppNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.AppRefNo));
            RuleFor(x => x.AppRefNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.IBMBAppNo));
        }
    }

    public class LoanAppStatInqRs : EsbNonT24CommonRs {
        public LoanAppStatInqLoanAppStatInqRec LoanAppStatInqRec { get; set; }
    }

    public class LoanAppStatInqLoanAppStatInqRec {
        public string CustPermId { get; set; }
        public string AppRefNo { get; set; }
        public string AppChan { get; set; }
        public string AppType { get; set; }
        public string AppDate { get; set; }
        public string FlowStat { get; set; }
        public string AttchDocFlg { get; set; }
        public string ChgFlg { get; set; }
        public string TellerID { get; set; }
        public string TellerName { get; set; }
        public string AttDocMemo { get; set; }
        public IEnumerable <LoanAppStatInqLoanAppStatInqInfo> LoanAppStatInqInfo { get; set; }
    }

    public class LoanAppStatInqLoanAppStatInqInfo {
        public string AppNo { get; set; }
        public string eLoanStat { get; set; }
        public string OrigAppNo { get; set; }
        public string LoanType { get; set; }
        public string AppAmt { get; set; }
        public string ApprvAmt { get; set; }
        public string LoanTerm { get; set; }
        public string ApprvDate { get; set; }
        public string ApprvStat { get; set; }
        public string RjctCode { get; set; }
        public string DsbrDate { get; set; }
        public string BankId { get; set; }
        public string BrchId { get; set; }
        public string DsbrAcctNo { get; set; }
        public string IPAddr { get; set; }
        public string IdntyVrfyFlg { get; set; }
        public string AttDocId { get; set; }
        public string ArrngId { get; set; }
    }
}
