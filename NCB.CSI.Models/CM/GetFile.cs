using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CM {
    [Validator(typeof(GetFileRqValidator))]
    public class GetFileRq {
        public string NodeName { get; set; }
        public string UserID { get; set; }
        public string UnitCode { get; set; }
        public string ImageID { get; set; }
        public string ApplyNO { get; set; }
        public bool? UseWM { get; set; }
        public bool? Lastest { get; set; }
        public string Text { get; set; }
    }

    public class GetFileRqValidator : AbstractValidator<GetFileRq> {
        public GetFileRqValidator() {
            RuleFor(x => x.NodeName).NotEmpty();
            RuleFor(x => x.UserID).NotEmpty();
            RuleFor(x => x.UnitCode).NotEmpty();
            RuleFor(x => x.ApplyNO).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ImageID));
            RuleFor(x => x.ImageID).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ApplyNO));
            RuleFor(x => x.UseWM).NotEmpty();
            RuleFor(x => x.Lastest).NotEmpty().When(x => !string.IsNullOrWhiteSpace(x.ApplyNO));
            RuleFor(x => x.Text).NotEmpty().When(x => x.UseWM == true);
        }
    }

    public class GetFileRs : CmCommonRs {
        public IEnumerable<GetFileField> FieldList { get; set; }
    }

    public class GetFileField {
        public string DocumentName { get; set; }
        public string Index { get; set; }
        public string ImageID { get; set; }
        public string Result { get; set; }
        [IgnoreLogItem]
        public string Image { get; set; }
        public string ImageType { get; set; }
        public string CreateDateTime { get; set; }
    }
}
