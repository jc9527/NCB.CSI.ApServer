using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Loan {
    public class SendForEmailRq {
        public string caseNumber { get; set; }
        public string imageId { get; set; }
        public string pid { get; set; }
    }

    public class SendForEmailRqValidator : AbstractValidator<SendForEmailRq> {
        public SendForEmailRqValidator() {
            RuleFor(x => x.caseNumber).NotEmpty();
            RuleFor(x => x.imageId).NotEmpty();
            RuleFor(x => x.pid).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class SendForEmailRs : BmsCommonRs<object> {
    }
}
