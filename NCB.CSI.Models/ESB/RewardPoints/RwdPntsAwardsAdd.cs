using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    [Validator(typeof(RwdPntsAwardsAddRqValidator))]
    public class RwdPntsAwardsAddRq : EsbRqServiceBody {
        public string MmbId { get; set; }
        public string CustPermId { get; set; }
        public string CCSId { get; set; }
        public string CampId { get; set; }
        public string TxnCode { get; set; }
        public string TxnType { get; set; }
        public string RwdPnts { get; set; }
        public string ShrtPoint { get; set; }
        public string AppDate { get; set; }
        public string Memo { get; set; }

    }
    public class RwdPntsAwardsAddRqValidator : AbstractValidator<RwdPntsAwardsAddRq> {
        public RwdPntsAwardsAddRqValidator() {
            RuleFor(x => x.MmbId).NotEmpty();
            RuleFor(x => x.CampId).NotEmpty();
            RuleFor(x => x.TxnCode).NotEmpty();
            RuleFor(x => x.TxnType).NotEmpty();
            RuleFor(x => x.RwdPnts).NotEmpty();
        }
    }
    public class RwdPntsAwardsAddRs : EsbNonT24CommonRs {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
        public RwdPntsAwardsAddRwdPntsAwardsAddInfo RwdPntsAwardsAddInfo { get; set; }
    }
    public class RwdPntsAwardsAddRwdPntsAwardsAddInfo {
        public string MmbId { get; set; }
        public string CampId { get; set; }
        public string TxnCode { get; set; }
        public string RwdPnts { get; set; }
        public string AvailPnts { get; set; }
    }
}
