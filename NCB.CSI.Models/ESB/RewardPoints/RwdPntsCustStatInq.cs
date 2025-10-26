using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class RwdPntsCustStatInqRq : EsbRqServiceBody {
        public string MmbId { get; set; }
    }
    public class RwdPntsCustStatInqRqValidator : AbstractValidator<RwdPntsCustStatInqRq> {
        public RwdPntsCustStatInqRqValidator() {
            RuleFor(x => x.MmbId).NotEmpty();
        }
    }
    public class RwdPntsCustStatInqRs : EsbNonT24CommonRs {
        public RwdPntsCustStatInqRwdPntsCustStatInqInfo RwdPntsCustStatInqInfo { get; set; }
    }
    public class RwdPntsCustStatInqRwdPntsCustStatInqInfo {
        public string BlackListFlg { get; set; }
        public IEnumerable<string> BlkApiType { get; set; }
    }
}
