using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.Common {
    [Validator(typeof(UpdatePersonalInfoRqValidator))]
    public class UpdatePersonalInfoRq {
        public string createMasterSeqNo { get; set; }
        public string name { get; set; }
        public string aboriginalName { get; set; }
        public string organization { get; set; }
        public BmsAddress residentAddress { get; set; }
        public BmsAddress cardAddress { get; set; }
    }

    public class BmsAddress {
        public string city { get; set; }
        public string district { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
    }

    public class UpdatePersonalInfoRqValidator : AbstractValidator<UpdatePersonalInfoRq> {
        public UpdatePersonalInfoRqValidator() {
            RuleFor(x => x.createMasterSeqNo).NotEmpty();
        }
    }

    public class UpdatePersonalInfoRs : BmsCommonRs<object> {
    }
}
