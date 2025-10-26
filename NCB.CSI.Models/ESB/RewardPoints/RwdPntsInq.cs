using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class RwdPntsInqRq : EsbRqServiceBody {
        public string MmbId { get; set; }
    }
    public class RwdPntsInqRqValidator : AbstractValidator<RwdPntsInqRq> {
        public RwdPntsInqRqValidator() {
            RuleFor(x => x.MmbId).NotEmpty();
        }
    }
    public class RwdPntsInqRs : EsbNonT24CommonRs {
        public RwdPntsInqRsRwdPntsInqInfo RwdPntsInqInfo { get; set; }
    }

    public class RwdPntsInqRsRwdPntsInqInfo {
        public decimal RwdPnts { get; set; }
    }
}
