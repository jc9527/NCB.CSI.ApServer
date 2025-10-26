using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;

namespace NCB.CSI.Models.BMS.CreateAccount {
    [Validator(typeof(GetCaseListRqValidator))]
    public class GetCaseListRq {
        public string status { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
    }

    public class GetCaseListRqValidator : AbstractValidator<GetCaseListRq> {
        public GetCaseListRqValidator() {
            RuleFor(x => x.status).NotEmpty();
            RuleFor(x => x.startDate).NotEmpty().Matches(RegExConst.YYYYMMDDHHNNSS);
            RuleFor(x => x.endDate).NotEmpty().Matches(RegExConst.YYYYMMDDHHNNSS);
        }
    }

    public class GetCaseListRs : BmsCommonRs<IEnumerable<GetCaseListData>> {
    }

    public class GetCaseListData {
        public string SeqNo { get; set; }
        public string Name { get; set; }
        public string Idno { get; set; }
        public string Phone { get; set; }
        public string LastStepDateTime { get; set; }
        public BmsManualReviewFlag manualReviewFlag { get; set; }
        public IEnumerable<BmsDocumentResend> documentResends { get; set; }
    }
}
