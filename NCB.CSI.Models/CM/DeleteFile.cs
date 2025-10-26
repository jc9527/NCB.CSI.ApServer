using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CM {
    [Validator(typeof(DeleteFileRqValidator))]
    public class DeleteFileRq {
        public string NodeName { get; set; }
        public string UserID { get; set; }
        public string UnitCode { get; set; }
        public string ImageID { get; set; }
        public string ApplyNO { get; set; }
    }

    public class DeleteFileRqValidator : AbstractValidator<DeleteFileRq> {
        public DeleteFileRqValidator() {
            RuleFor(x => x.NodeName).NotEmpty();
            RuleFor(x => x.UserID).NotEmpty();
            RuleFor(x => x.UnitCode).NotEmpty();
            RuleFor(x => x.ApplyNO).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ImageID));
            RuleFor(x => x.ImageID).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ApplyNO));
        }
    }

    public class DeleteFileRs : CmCommonRs {
    }
}
