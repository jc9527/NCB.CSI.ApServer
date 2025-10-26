using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(PreDsgntdLmtHisInqRqValidator))]
    public class PreDsgntdLmtHisInqRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
    }

    public class PreDsgntdLmtHisInqRqValidator : AbstractValidator<PreDsgntdLmtHisInqRq> {
        public PreDsgntdLmtHisInqRqValidator() {
            RuleFor(x => x.AcctNo).NotEmpty();
        }
    }

    public class PreDsgntdLmtHisInqRs : EsbNonT24CommonRs {
        public PreDsgntdLmtHisInqPDLmtAmtHistInqInfo PDLmtAmtHistInqInfo { get; set; }
    }

    public class PreDsgntdLmtHisInqPDLmtAmtHistInqInfo {
        public IEnumerable<PreDsgntdLmtHisInqPDLmtAmtHistInqRec> PDLmtAmtHistInqRec { get; set; }
    }

    public class PreDsgntdLmtHisInqPDLmtAmtHistInqRec {
        public string RsrvdAcctNo { get; set; }
        public string PDLmtAmtBrf { get; set; }
        public string PDLmtAmtAftr { get; set; }
        public string UpdDate { get; set; }
        public string UpdTime { get; set; }
        public string UpdUserId { get; set; }
        public string UpdBrch { get; set; }
    }
}
