using FluentValidation;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class RwdPntsExpInqRq : EsbRqServiceBody {
        public string MmbId { get; set; }
        public string ExpDate { get; set; }
    }
    public class RwdPntsExpInqRqValidator : AbstractValidator<RwdPntsExpInqRq> {
        public RwdPntsExpInqRqValidator() {
            RuleFor(x => x.MmbId).NotEmpty();
            RuleFor(x => x.ExpDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }
    public class RwdPntsExpInqRs : EsbNonT24CommonRs {
        public RwdPntsExpInqRwdPntsExpInqInfo RwdPntsExpInqInfo { get; set; }
    }
    public class RwdPntsExpInqRwdPntsExpInqInfo {
        public string ExpPnts { get; set; }
    }
}
