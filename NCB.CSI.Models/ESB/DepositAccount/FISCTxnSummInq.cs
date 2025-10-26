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

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(FISCTxnSummInqRqValidator))]
    public class FISCTxnSummInqRq : EsbInqCommonRq {
        public string InqDate { get; set; }
    }

    public class FISCTxnSummInqRqValidator : AbstractValidator<FISCTxnSummInqRq> {
        public FISCTxnSummInqRqValidator() {
            RuleFor(x => x.InqDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class FISCTxnSummInqRs : EsbT24InqCommonRs {
        public IEnumerable<FISCTxnSummRec> FISCTxnSummRec { get; set; }
    }

    public class FISCTxnSummRec {
        public IEnumerable<FISCTxnSummInfo> FISCTxnSummInfo { get; set; }
    }

    public class FISCTxnSummInfo {
        public string IBMBDbCnt { get; set; }
        public string IBMBDbAmt { get; set; }
        public string IBMBCrCnt { get; set; }
        public string IBMBCrAmt { get; set; }
        public string RmtDbCnt { get; set; }
        public string RmtDbAmt { get; set; }
        public string RmtCrCnt { get; set; }
        public string RmtCrAmt { get; set; }
        public string FXMLDbCnt { get; set; }
        public string FXMLDbAmt { get; set; }
        public string FXMLCrCnt { get; set; }
        public string FXMLCrAmt { get; set; }
    }
}
