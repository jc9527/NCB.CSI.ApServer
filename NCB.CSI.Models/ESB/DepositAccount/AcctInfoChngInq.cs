using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(AcctInfoChngInqRqValidator))]
    public class AcctInfoChngInqRq : EsbInqCommonRq {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public string StartDateEndDate { get; set; }
    }

    public class AcctInfoChngInqRqValidator : AbstractValidator<AcctInfoChngInqRq> {
        public AcctInfoChngInqRqValidator() {

        }
    }

    public class AcctInfoChngInqRs : EsbT24InqCommonRs {
        public IEnumerable<AcctInfoChngInqAcctInfoChngInqRec> AcctInfoChngInqRec { get; set; }
    }

    public class AcctInfoChngInqAcctInfoChngInqRec {
        public string TxnLogId { get; set; }
        public IEnumerable<AcctInfoChngInqTxnLogRec> TxnLogRec { get; set; }
        public IEnumerable<AcctInfoChngInqEntryEmplRec> EntryEmplRec { get; set; }
        public IEnumerable<AcctInfoChngInqAuthEmpIRec> AuthEmpIRec { get; set; }
    }

    public class AcctInfoChngInqTxnLogRec {
        public string AcctNo { get; set; }
        public string Chan { get; set; }
        public string UpdDate { get; set; }
        public string UpdTime { get; set; }
        public IEnumerable<AcctInfoChngInqUpdRec> UpdRec { get; set; }
    }

    public class AcctInfoChngInqUpdRec {
        public string UpdFld { get; set; }
        public string UpdDataBrf { get; set; }
        public string UpdDataAftr { get; set; }
    }

    public class AcctInfoChngInqEntryEmplRec {
        public string EntryEmplNo { get; set; }
    }

    public class AcctInfoChngInqAuthEmpIRec {
        public string AuthEmpId { get; set; }
    }
}
