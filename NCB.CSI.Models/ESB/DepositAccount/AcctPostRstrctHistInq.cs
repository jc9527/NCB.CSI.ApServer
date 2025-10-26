using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.ESB;
using NCB.CSI.Models.ESB.DepositAccount;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(AcctPostRstrctHistInqRqValidator))]
    public class AcctPostRstrctHistInqRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public string PostRstrctCode { get; set; }
    }

    public class AcctPostRstrctHistInqRqValidator : AbstractValidator<AcctPostRstrctHistInqRq> {
        public AcctPostRstrctHistInqRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
        }
    }

    public class AcctPostRstrctHistInqRs : EsbT24InqCommonRs {
        public IEnumerable<AcctPostRstrctHistInqAcctPostRstrctHistInqRec> AcctPostRstrctHistInqRec { get; set; }
    }

    public class AcctPostRstrctHistInqAudit {
        public string T24Time { get; set; }
        public string VerNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }

    public class AcctPostRstrctHistInqAcctPostRstrctHistInqRec {
        public string ArrngId { get; set; }
        public string AcctNo { get; set; }
        public string CustPermId { get; set; }
        public IEnumerable<AcctPostRstrctHistInqAcctPostRstrctHistInqlInfo> AcctPostRstrctHistInqlInfo { get; set; }
    }

    public class AcctPostRstrctHistInqAcctPostRstrctHistInqlInfo {
        public string AcctTitl { get; set; }
        public string ProdName { get; set; }
        public string CustChnName { get; set; }
        public IEnumerable<AcctPostRstrctHistInqPostRstrctCodeRec> PostRstrctCodeRec { get; set; }
        public IEnumerable<AcctPostRstrctHistInqPostRsnRec> PostRsnRec { get; set; }
    }

    public class AcctPostRstrctHistInqPostRstrctCodeRec {
        public string PostRstrctCode { get; set; }
        public string PostRstrctRsn { get; set; }
        public string PostRstrctType { get; set; }
    }

    public class AcctPostRstrctHistInqPostRsnRec {
        public string PostRsnCode { get; set; }
        public string PostRsn { get; set; }
        public string PostRstrctRlsRsnCode { get; set; }
        public string PostRstrctRlsRsn { get; set; }
        public string PostRstrctAppDate { get; set; }
        public string PostRstrctRlsDate { get; set; }
    }
}


