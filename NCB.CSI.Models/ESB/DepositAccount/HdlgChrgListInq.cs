using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(HdlgChrgListInqRqValidator))]
    public class HdlgChrgListInqRq : EsbInqCommonRq {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public string HdlgChrgType { get; set; }
    }

    public class HdlgChrgListInqRqValidator : AbstractValidator<HdlgChrgListInqRq> {
        public HdlgChrgListInqRqValidator() {
            RuleFor(x => x.AcctNo).NotEmpty();
        }
    }

    public class HdlgChrgListInqRs : EsbT24InqCommonRs {
        public IEnumerable<HdlgChrgListInqHdlgChrgListInqRec> HdlgChrgListInqRec { get; set; }
    }

    public class HdlgChrgListInqHdlgChrgListInqRec {
        public string AvailBal { get; set; }
        public IEnumerable<HdlgChrgListInqHdlgChrgListInqlInfo> HdlgChrgListInqlInfo { get; set; }
    }

    public class HdlgChrgListInqHdlgChrgListInqlInfo {
        public string AcctNo { get; set; }
        public string HdlgChrgType { get; set; }
        public string HdlgChrgUpdDate { get; set; }
        public string MaxHdlgChrgCnt { get; set; }
        public string HdlgChrgCnt { get; set; }
        public string HdlgChrgTypeMemo { get; set; }
    }
}
