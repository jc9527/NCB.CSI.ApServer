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
    [Validator(typeof(GetMemberInfoRqValidator))]
    public class GetMemberInfoRq {
        public MemberInfo memberInfo { get; set; }
        public string memberId { get; set; }
    }

    public class GetMemberInfoRqValidator : AbstractValidator<GetMemberInfoRq> {
        public GetMemberInfoRqValidator() {
            RuleFor(x => x.memberInfo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.memberId));
            RuleFor(x => x.memberId).NotEmpty().When(x => x.memberInfo == null);
        }
    }

    [Validator(typeof(MemberInfoValidator))]
    public class MemberInfo {
        public string phoneNumber { get; set; }
        [LogItem("CustId")]
        public string identity { get; set; }
    }

    public class MemberInfoValidator : AbstractValidator<MemberInfo> {
        public MemberInfoValidator() {
            RuleFor(x => x.phoneNumber).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.identity));
            RuleFor(x => x.identity).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.phoneNumber));
        }
    }

    public class GetMemberInfoRs : BmsCommonRs<GetMemberInfoData> {
    }

    public class GetMemberInfoData {
        public MemberInfo memberInfo { get; set; }
        public bool isEmailVerified { get; set; }
        public string memberId { get; set; }
        public IEnumerable<BmsDocumentResend> documentResends { get; set; }
    }
}
