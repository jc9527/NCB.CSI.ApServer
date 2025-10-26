using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Rate {
    [Validator(typeof(AddRateRqValidator))]
    public class AddRateRq {
        public string category { get; set; }
        public string amountType { get; set; }
        public int? period { get; set; }
        public string rateType { get; set; }
        public decimal rate { get; set; }
        public DateTime rateEffectSDate { get; set; }
        [JsonProperty(PropertyName = "operator")]
        public string user { get; set; }
    }

    public class AddRateRqValidator : AbstractValidator<AddRateRq> {
        public AddRateRqValidator() {
            RuleFor(x => x.category).NotEmpty();
            RuleFor(x => x.rate).NotEmpty();
            RuleFor(x => x.rateEffectSDate).NotEmpty();
            RuleFor(x => x.user).NotEmpty();
        }
    }

    public class AddRateRs : BmsCommonRs<object> {
    }
}
