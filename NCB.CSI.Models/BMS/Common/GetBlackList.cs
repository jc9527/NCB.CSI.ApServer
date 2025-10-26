using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.Common {
    [Validator(typeof(GetBlackListRqValidator))]
    public class GetBlackListRq {
        public string identity { get; set; }
        public string category { get; set; }
    }

    public class GetBlackListRqValidator : AbstractValidator<GetBlackListRq> {
        public GetBlackListRqValidator() {
        }
    }

    public class GetBlackListRs : BmsCommonRs<IEnumerable<BlackItem>> {
    }

    public class BlackItem {
        public string BlackListSeqNo { get; set; }
        public string identity { get; set; }
        public string category { get; set; }
        public string createReason { get; set; }
        public string delReason { get; set; }
        public string creator { get; set; }
        public string modifier { get; set; }
        public string createDate { get; set; }
        public string createTime { get; set; }
        public string updateDate { get; set; }
        public string updateTime { get; set; }
        public bool? isDelete { get; set; }
    }
}
