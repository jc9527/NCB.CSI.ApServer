using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class PointCampGrpInqRq : EsbRqServiceBody {
        public string FnctCode { get; set; }
        public string PointCampGrpNo { get; set; }
        public string PointCampGrpName { get; set; }
    }
    public class PointCampGrpInqRqValidator : AbstractValidator<PointCampGrpInqRq> {
        public PointCampGrpInqRqValidator() {
            RuleFor(x => x.FnctCode).NotEmpty();
        }
    }
    public class PointCampGrpInqRs : EsbNonT24CommonRs {
        public PointCampGrpInqPointCampGrpInqRec PointCampGrpInqRec { get; set; }
    }
    public class PointCampGrpInqPointCampGrpInqRec {
        public string FnctType { get; set; }
        public IEnumerable<PointCampGrpInqPointCampGrpInqInfo> PointCampGrpInqInfo { get; set; }
    }
    public class PointCampGrpInqPointCampGrpInqInfo {
        public string PointCampGrpNo { get; set; }
        public string PointCampGrpName { get; set; }
    }
}
