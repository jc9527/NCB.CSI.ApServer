using FluentValidation;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.RewardPoints {
    public class RwdPntsHistInqRq : EsbRqServiceBody {
        public int NoOfPage { get; set; } = 10;
        public int PageNo { get; set; } = 1;
        public string MmbId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    public class RwdPntsHistInqRqValidator : AbstractValidator<RwdPntsHistInqRq> {
        public RwdPntsHistInqRqValidator() {
            RuleFor(x => x.MmbId).NotEmpty();
            RuleFor(x => x.StartDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }
    public class RwdPntsHistInqRs : EsbNonT24CommonRs {
        public IEnumerable<RwdPntsHistInqRwdPntsHistInqInfo> RwdPntsHistInqInfo { get; set; }
        public string NoOfCurPage { get; set; }
        public string CurPage { get; set; }
        public string NoOfRec { get; set; }
    }
    public class RwdPntsHistInqRwdPntsHistInqInfo {
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string CampId { get; set; }
        public string CampName { get; set; }
        public string PntsAwrds { get; set; }
        public string PntsRed { get; set; }
        public string TxnCode { get; set; }
        public string TxnType { get; set; }
        public string OrdNo { get; set; }
        public string OrdName { get; set; }
        public string Memo { get; set; }
        public string ExpDate { get; set; }
        public string AvailPnts { get; set; }
    }
}
