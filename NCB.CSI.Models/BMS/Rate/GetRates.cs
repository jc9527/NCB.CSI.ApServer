using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Rate {
    [Validator(typeof(GetRatesRqValidator))]
    public class GetRatesRq {
        public string commonOrder { get; set; }
        public string largeAmountOrder { get; set; }
        public DateTime rateDate { get; set; }
    }

    public class GetRatesRqValidator : AbstractValidator<GetRatesRq> {
        public GetRatesRqValidator() {
            RuleFor(x => x.commonOrder).NotEmpty();
            RuleFor(x => x.largeAmountOrder).NotEmpty();
            RuleFor(x => x.rateDate).NotEmpty();
        }
    }

    public class GetRatesRs : BmsCommonRs<GetRatesData> {
    }

    public class GetRatesData {
        public long listingDate { get; set; }
        public long implementationDate { get; set; }
        public IEnumerable<BmsRate> typeRate { get; set; }
        public IEnumerable<BmsRate> timeDepositRates { get; set; }
        public IEnumerable<BmsRate> largeDenominationTimeDepositRates { get; set; }
        public string largeDenomination { get; set; }
    }

    public class BmsRate {
        public string content { get; set; }
        public decimal? rate { get; set; }
        public decimal? floatingRate { get; set; }
    }
}
