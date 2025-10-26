using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(PreDsgntdAcctStatInqRqValidator))]
    public class PreDsgntdAcctStatInqRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class PreDsgntdAcctStatInqRqValidator : AbstractValidator<PreDsgntdAcctStatInqRq> {
        public PreDsgntdAcctStatInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class PreDsgntdAcctStatInqRs : EsbNonT24CommonRs {
        public IEnumerable<PreDsgntdAcctStatInqPreDsgntdAcctInfo> PreDsgntdAcctInfo { get; set; }
    }

    public class PreDsgntdAcctStatInqPreDsgntdAcctInfo {
        public string CustPermId { get; set; }
        public string PDXferFlg { get; set; }
    }
}
