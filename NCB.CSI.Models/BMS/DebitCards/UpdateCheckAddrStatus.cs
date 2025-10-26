using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.BMS.CreateAccount;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.DebitCards {
    [Validator(typeof(UpdateCheckAddrStatusRqValidator))]
    public class UpdateCheckAddrStatusRq {
        public string seqNo { get; set; }
        public string idno { get; set; }
    }

    public class UpdateCheckAddrStatusRqValidator : AbstractValidator<UpdateCheckAddrStatusRq> {
        public UpdateCheckAddrStatusRqValidator() {
            //RuleFor(x => x.seqNo).NotEmpty();
            RuleFor(x => x.idno).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class UpdateCheckAddrStatusRs : BmsCommonRs<object> {
    }
}
