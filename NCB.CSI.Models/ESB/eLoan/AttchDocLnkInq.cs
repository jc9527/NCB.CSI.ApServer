using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(AttchDocLnkInqRqValidator))]
    public class AttchDocLnkInqRq : EsbRqServiceBody {
        public AttchDocLnkInqAttchDocLnkInqRec AttchDocLnkInqRec { get; set; }
    }
    public class AttchDocLnkInqAttchDocLnkInqRec {
        public string AttDocType { get; set; }
        public string AttDocName { get; set; }
        public string AttDocId { get; set; }
    }
    public class AttchDocLnkInqRqValidator : AbstractValidator<AttchDocLnkInqRq> {
        public AttchDocLnkInqRqValidator() {
            RuleFor(x => x.AttchDocLnkInqRec).NotEmpty();
            RuleFor(x => x.AttchDocLnkInqRec.AttDocId).NotEmpty();
        }
    }
    public class AttchDocLnkInqRs : EsbNonT24CommonRs {
    }
}
