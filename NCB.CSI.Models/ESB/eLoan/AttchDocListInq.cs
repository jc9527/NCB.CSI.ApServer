using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(AttchDocListInqRqValidator))]
    public class AttchDocListInqRq : EsbRqServiceBody {
        public string AppRefNo { get; set; }
    }
    public class AttchDocListInqRqValidator : AbstractValidator<AttchDocListInqRq> {
        public AttchDocListInqRqValidator() {
            RuleFor(x => x.AppRefNo).NotEmpty();
        }
    }
    public class AttchDocListInqRs : EsbNonT24CommonRs {
        public AttchDocListInqAttchDocListInqRec AttchDocListInqRec { get; set; }
    }
    public class AttchDocListInqAttchDocListInqRec {
        public string AppRefNo { get; set; }
        public IEnumerable<AttchDocListInqAttchDocListInqInfo> AttchDocListInqInfo { get; set; }
    }
    public class AttchDocListInqAttchDocListInqInfo {
        public string AttDocType { get; set; }
        public string AttDocName { get; set; }
        public string AttDocId { get; set; }
    }
}
