using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.ESB;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(LoanCtrctAddRqValidator))]
    public class LoanCtrctAddRq : EsbRqServiceBody {
        public string CustPermId { get; set; }
        public string AppRefNo { get; set; }
        public string AppNo { get; set; }
        public string GrntedRslt { get; set; }
        public string RjctRsn { get; set; }
        public string AuthType { get; set; }
        public string IdntyVrfyType { get; set; }
        public string IdntyVrfyDate { get; set; }
        public string IPAddr { get; set; }
        public string RvwDate { get; set; }
        public string SgntrDate { get; set; }
        public string IdntyVrfyFlg { get; set; }
        public string IdntyVrfyTellerID { get; set; }
        public string IdntyVrfyTellerName { get; set; }
        public string IdntyVrfyTellerDate { get; set; }
    }
    public class LoanCtrctAddRqValidator : AbstractValidator<LoanCtrctAddRq> {
        public LoanCtrctAddRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches("^[A-Z][1,2][0-9]{8}$");
            RuleFor(x => x.AppRefNo).NotEmpty();
            RuleFor(x => x.AppNo).NotEmpty();
        }
    }
    public class LoanCtrctAddRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
        public LoanCtrctAddRecLoanCtrctAdd LoanCtrctAdd { get; set; }
    }
    public class LoanCtrctAddRecLoanCtrctAdd {
        public string CustPermId { get; set; }
        public string AppRefNo { get; set; }
        public string AppNo { get; set; }
        public string AttDocId { get; set; }
    }
}
