using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(PreDsgntdAcctInqRqValidator))]
    public class PreDsgntdAcctInqRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string InqType { get; set; }
    }

    public class PreDsgntdAcctInqRqValidator : AbstractValidator<PreDsgntdAcctInqRq> {
        public PreDsgntdAcctInqRqValidator() {
            RuleFor(x => x.InqType).NotEmpty();
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class PreDsgntdAcctInqRs : EsbNonT24CommonRs {
        public IEnumerable<PreDsgntdAcctInqDbAcctInfo> DbAcctInfo { get; set; }
        public IEnumerable<PreDsgntdAcctInqCrAcctInfo> CrAcctInfo { get; set; }
    }

    public class PreDsgntdAcctInqDbAcctInfo {
        public string DbAcctNo { get; set; }
    }

    public class PreDsgntdAcctInqCrAcctInfo {
        public string AliasName { get; set; }
        public string CrBankId { get; set; }
        public string CrAcctNo { get; set; }
        public string SameIdFlg { get; set; }
        public string LmtAmt { get; set; }
        public string AmtCcy { get; set; }
        public string EffDate { get; set; }
        public string UpdtDate { get; set; }
    }
}
