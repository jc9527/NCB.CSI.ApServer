using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class VndrRwdPntsInqRq : EsbRqServiceBody {
        public string VndrName { get; set; }
        public string VndrMmbId { get; set; }
    }
    public class VndrRwdPntsInqRqValidator : AbstractValidator<VndrRwdPntsInqRq> {
        public VndrRwdPntsInqRqValidator() {
            RuleFor(x => x.VndrName).NotEmpty();
            RuleFor(x => x.VndrMmbId).NotEmpty();
        }
    }
    public class VndrRwdPntsInqRs : EsbNonT24CommonRs {
        public VndrRwdPntsInqVndrRwdPntsInqInfo VndrRwdPntsInqInfo { get; set; }
    }
    public class VndrRwdPntsInqVndrRwdPntsInqInfo {
        public string VndrRwdPnts { get; set; }
        public string VndrRtrnCode { get; set; }
        public string VndrRtrnDesc { get; set; }
    }
}
