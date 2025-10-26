using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.CreateAccount {
    [Validator(typeof(UpdateStatusRqValidator))]
    public class UpdateStatusRq {
        public string seqNo { get; set; }
        public string prodType { get; set; }
        public string status { get; set; }
        public IEnumerable<UpdateStatusResendCase> resendCase { get; set; }
        public string rejectReason { get; set; }
        public string managerNo { get; set; }
    }

    public class UpdateStatusResendCase {
        public string resendSeqNo { get; set; }
        public string category { get; set; }
        public string resendReason { get; set; }
        public string resendStatus { get; set; }
        public string resendRejectReason { get; set; }
    }

    public class UpdateStatusRqValidator : AbstractValidator<UpdateStatusRq> {
        public UpdateStatusRqValidator() {
            RuleFor(x => x.seqNo).NotEmpty();
            RuleFor(x => x.prodType).NotEmpty();
            RuleFor(x => x.status).NotEmpty();
        }
    }

    public class UpdateStatusRs : BmsCommonRs<object> {
    }
}
