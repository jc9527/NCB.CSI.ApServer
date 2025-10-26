using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CM {
    [Validator(typeof(CallViewerRqValidator))]
    public class CallViewerRq {
        public string NodeName { get; set; }
        public string UserID { get; set; }
        public string UnitCode { get; set; }
        public string ApplyNO { get; set; }
        public string ImageID { get; set; }
        public bool? Lastest { get; set; }
        public string Text { get; set; }
    }

    public class CallViewerRqValidator : AbstractValidator<CallViewerRq> {
        public CallViewerRqValidator() {
            RuleFor(x => x.NodeName).NotEmpty();
            RuleFor(x => x.UserID).NotEmpty();
            RuleFor(x => x.UnitCode).NotEmpty();
            RuleFor(x => x.ApplyNO).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ImageID));
            RuleFor(x => x.ImageID).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ApplyNO));
            RuleFor(x => x.Lastest).NotEmpty().When(x => !string.IsNullOrWhiteSpace(x.ApplyNO));
        }
    }

    public class CallViewerRs : CmCommonRs {
        public string URL { get; set; }
        public IEnumerable<CallViewerField> FieldList { get; set; }
    }

    public class CallViewerField {
        public string DocumentName { get; set; }
        public string Index { get; set; }
        public string ImageID { get; set; }
        public int Result { get; set; }
        public string CreateDateTime { get; set; }
    }
}
