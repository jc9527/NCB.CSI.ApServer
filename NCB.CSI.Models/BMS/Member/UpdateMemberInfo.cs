using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Member {
    [Validator(typeof(UpdateMemberInfoRqValidator))]
    public class UpdateMemberInfoRq {
        public string cifNo { get; set; }
        public string chineseName { get; set; }
        [LogItem("CustId")]
        public string pid { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string aboriginalName { get; set; }
        public string maillingCity { get; set; }
        public string mailingDistrict { get; set; }
        public string mailingAddress { get; set; }
        public string mailingPostalCode { get; set; }
        public string residentCity { get; set; }
        public string residentDistrict { get; set; }
        public string residentAddress { get; set; }
        public string residentPostalCode { get; set; }
    }

    public class UpdateMemberInfoRqValidator : AbstractValidator<UpdateMemberInfoRq> {
        public UpdateMemberInfoRqValidator() {
            RuleFor(x => x.cifNo).NotEmpty();
        }
    }

    public class UpdateMemberInfoRs : BmsCommonRs<object> {
    }
}
