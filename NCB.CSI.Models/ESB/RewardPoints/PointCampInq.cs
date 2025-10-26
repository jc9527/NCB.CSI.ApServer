using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class PointCampInqRq : EsbRqServiceBody {
        public string FnctCode { get; set; }
        public string CampId { get; set; }
        public string CampName { get; set; }

    }
    public class PointCampInqRqValidator : AbstractValidator<PointCampInqRq> {
        public PointCampInqRqValidator() {
            RuleFor(x => x.FnctCode).NotEmpty();
        }
    }
    public class PointCampInqRs : EsbNonT24CommonRs {
        public PointCampInqPointCampInqRec PointCampInqRec { get; set; }

    }
    public class PointCampInqPointCampInqRec {
        public string FnctCode { get; set; }
        public IEnumerable<PointCampInqPointCampInqInfo> PointCampInqInfo { get; set; }
    }
    public class PointCampInqPointCampInqInfo {
        public string CampId { get; set; }
        public string PointCampType { get; set; }
        public string CampPointAddCode { get; set; }
        public string PointCampGrpNo { get; set; }
        public string CampName { get; set; }
        public string PointBussType { get; set; }
        public string CampStartDateTime { get; set; }
        public string CampEndDateTime { get; set; }
        public string ExpTypeCfg { get; set; }
        public string VldDate { get; set; }
        public string VldPrdYear { get; set; }
        public string VldPrdMnth { get; set; }
        public string CostCtr { get; set; }
        public string IndvPointCntAddLmt { get; set; }
        public string IndvPointAddLmt { get; set; }
        public string IndvPointMnthAddLmt { get; set; }
        public string CampTtlRwdPntsLmt { get; set; }
        public string HostCntct { get; set; }
        public string HostEmailAddr { get; set; }
        public string UpdUserEmailAddr { get; set; }
        public string Memo { get; set; }
    }
}
