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

namespace NCB.CSI.Models.BMS.Point {
    [Validator(typeof(AddPointHistoryRqValidator))]
    public class AddPointHistoryRq {
        public string type { get; set; }
        public string memberId { get; set; }
        public string campaignId { get; set; }
        public string campaignName { get; set; }
        public string txnCode { get; set; }
        public decimal point { get; set; }
    }

    public class AddPointHistoryRqValidator : AbstractValidator<AddPointHistoryRq> {
        public AddPointHistoryRqValidator() {
            RuleFor(x => x.type).Must(x => new[] { "ADD", "DEDUCT" }.Contains(x));
            RuleFor(x => x.memberId).NotEmpty();
            RuleFor(x => x.campaignId).NotEmpty();
            RuleFor(x => x.campaignName).NotEmpty();
            RuleFor(x => x.txnCode).NotEmpty();
            RuleFor(x => x.point).NotEmpty();
        }
    }

    public class AddPointHistoryRs : BmsCommonRs<object> {
    }
}
