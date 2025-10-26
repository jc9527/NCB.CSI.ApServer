using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CM {
    [Validator(typeof(UploadFileRqValidator))]
    public class UploadFileRq {
        public string UnitCode { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }
        public string NodeName { get; set; }
        public string ApplyNO { get; set; }
        public string ActNO1 { get; set; }
        public string ActNO2 { get; set; }
        public string ActNO3 { get; set; }
        public string ActNO4 { get; set; }
        public string ActNO5 { get; set; }
        public string BRNO { get; set; }
        public string TBSDY { get; set; }
        public string DocumentName { get; set; }
        public string Image { get; set; }
        public string ImageType { get; set; }
    }

    public class UploadFileRqValidator : AbstractValidator<UploadFileRq> {
        public UploadFileRqValidator() {
            RuleFor(x => x.UnitCode).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.UserID).NotEmpty();
            RuleFor(x => x.NodeName).NotEmpty();
            RuleFor(x => x.ApplyNO).NotEmpty();
            RuleFor(x => x.ActNO1).NotEmpty();
            RuleFor(x => x.BRNO).NotEmpty();
            RuleFor(x => x.TBSDY).NotEmpty();
            RuleFor(x => x.DocumentName).NotEmpty();
            RuleFor(x => x.Image).NotEmpty();
            RuleFor(x => x.ImageType).NotEmpty();
        }
    }

    public class UploadFileRs : CmCommonRs {
        public string DocumentName { get; set; }
        public string Index { get; set; }
        public string ImageID { get; set; }
    }
}
