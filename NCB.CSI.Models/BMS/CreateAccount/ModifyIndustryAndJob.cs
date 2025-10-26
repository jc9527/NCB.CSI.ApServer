using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;

namespace NCB.CSI.Models.BMS.CreateAccount {
    [Validator(typeof(ModifyIndustryAndJobRqValidator))]
    public class ModifyIndustryAndJobRq {
        public string phoneNumber { get; set; }
        public string idNo { get; set; }
        public BmsCodeAndValue job { get; set; }
        public BmsCodeAndValue industry { get; set; }
    }

    public class ModifyIndustryAndJobRqValidator : AbstractValidator<ModifyIndustryAndJobRq> {
        public ModifyIndustryAndJobRqValidator() {
            RuleFor(x => x.phoneNumber).NotEmpty();
            RuleFor(x => x.idNo).NotEmpty().Matches(RegExConst.TwNid); ;
        }
    }

    public class ModifyIndustryAndJobRs : BmsCommonRs<object> {
    }
}
