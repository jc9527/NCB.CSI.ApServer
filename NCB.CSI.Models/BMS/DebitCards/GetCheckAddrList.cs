using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.DebitCards {
    [Validator(typeof(GetCheckAddrListRqValidator))]
    public class GetCheckAddrListRq {
        public string startDate { get; set; }
        public string endDate { get; set; }
    }

    public class GetCheckAddrListRqValidator : AbstractValidator<GetCheckAddrListRq> {
        public GetCheckAddrListRqValidator() {
            RuleFor(x => x.startDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.endDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class GetCheckAddrListRs : BmsCommonRs<IEnumerable<CheckAddrData>> {
    }

    public class CheckAddrData {
        public string seqNo { get; set; }
        public string idno { get; set; }
        public string name { get; set; }
        public string addr1 { get; set; }
        public string addr2 { get; set; }
        public string zipCode { get; set; }
        public string createDateTime { get; set; }
    }
}
