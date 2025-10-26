using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class PointVndrInqRq : EsbRqServiceBody {
        public string FnctCode { get; set; }
        public string CoNo { get; set; }
        public string CoCode { get; set; }
        public string CoName { get; set; }
    }
    public class PointVndrInqRqValidator : AbstractValidator<PointVndrInqRq> {
        public PointVndrInqRqValidator() {
            RuleFor(x => x.FnctCode).NotEmpty();
        }
    }
    public class PointVndrInqRs : EsbNonT24CommonRs {
        public PointVndrInqPointVndrInqRec PointVndrInqRec { get; set; }
    }
    public class PointVndrInqPointVndrInqRec {
        public string FnctCode { get; set; }
        public IEnumerable<PointVndrInqPointVndrInqInfo> PointVndrInqInfo { get; set; }
    }
    public class PointVndrInqPointVndrInqInfo {
        public string CoNo { get; set; }
        public string CoCode { get; set; }
        public string CoName { get; set; }
        public string UnincOrgId { get; set; }
        public string Memo { get; set; }
        public string ChartAcct { get; set; }
    }
}
