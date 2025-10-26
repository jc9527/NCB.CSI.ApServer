using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(PrectrctInqRqValidator))]
    public class PrectrctInqRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string AppRefNo { get; set; }
        public string AppNo { get; set; }
    }
    public class PrectrctInqRqValidator : AbstractValidator<PrectrctInqRq> {
        public PrectrctInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.AppRefNo).NotEmpty();
            RuleFor(x => x.AppNo).NotEmpty();
        }
    }
    public class PrectrctInqRs : EsbNonT24CommonRs {
        public PrectrctInqPrectrctInqRec PrectrctInqRec { get; set; }
    }
    public class PrectrctInqPrectrctInqRec {
        public string CustPermId { get; set; }
        public string AppRefNo { get; set; }
        public string AppNo { get; set; }
        public IEnumerable<PrectrctInqAttDocInfo> AttDocInfo { get; set; }
    }
    public class PrectrctInqAttDocInfo {
        public string AttDocType { get; set; }
        public string AttDocName { get; set; }
        public string AttDocId { get; set; }
    }
}
