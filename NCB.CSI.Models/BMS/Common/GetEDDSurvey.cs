using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.Common {
    [Validator(typeof(GetEDDSurveyRqValidator))]
    public class GetEDDSurveyRq {
        public string seqNo { get; set; }
    }

    public class GetEDDSurveyRqValidator : AbstractValidator<GetEDDSurveyRq> {
        public GetEDDSurveyRqValidator() {
            RuleFor(x => x.seqNo).NotEmpty();
        }
    }

    public class GetEDDSurveyRs : BmsCommonRs<GetEDDSurveyData> {
    }

    public class GetEDDSurveyData {
        public string othrUsedCustName { get; set; }
        public string aliasName { get; set; }
        public string coName { get; set; }
        public string coAddr { get; set; }
        public string bankId { get; set; }
        public string telephone { get; set; }
        public string wlthSrc { get; set; }
        public bool? isPrprtyFlg { get; set; }
        public bool? isFCYTaxFlg { get; set; }
        public string yearIncm { get; set; }
        public string chanMark { get; set; }
        public string acctUsage { get; set; }
        public string avgExpdtur { get; set; }
        public string pmtUsage { get; set; }
    }
}
