using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(PreDsgntdAcctHistInqRqValidator))]
    public class PreDsgntdAcctHistInqRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class PreDsgntdAcctHistInqRqValidator : AbstractValidator<PreDsgntdAcctHistInqRq> {
        public PreDsgntdAcctHistInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class PreDsgntdAcctHistInqRs : EsbNonT24CommonRs {
        public PreDsgntdAcctHistInqPreDsgntdAcctHistInqInfo PreDsgntdAcctHistInqInfo { get; set; }
    }

    public class PreDsgntdAcctHistInqPreDsgntdAcctHistInqInfo {
        public IEnumerable<PreDsgntdAcctHistInqRsrvdAcctListRec> RsrvdAcctListRec { get; set; }
    }

    public class PreDsgntdAcctHistInqRsrvdAcctListRec {
        public string FnctCode { get; set; }
        public string RsrvdType { get; set; }
        public string AliasName { get; set; }
        public string RsrvdBankId { get; set; }
        public string RsrvdAcctNo { get; set; }
        public string SameIdFlg { get; set; }
        public string UpdDate { get; set; }
        public string UpdTime { get; set; }
        public string UpdUserId { get; set; }
        public string UpdBrch { get; set; }
    }
}
