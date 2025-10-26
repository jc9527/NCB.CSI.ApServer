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
    [Validator(typeof(UnauthTxnListInqRqValidator))]
    public class UnauthTxnListInqRq : EsbInqCommonRq {
        public string InqTxnName { get; set; }
    }

    public class UnauthTxnListInqRqValidator : AbstractValidator<UnauthTxnListInqRq> {
        public UnauthTxnListInqRqValidator() {
        }
    }

    public class UnauthTxnListInqRs : EsbT24InqCommonRs {
        public IEnumerable<UnauthTxnListInqUnauthTxnListInqRec> UnauthTxnListInqRec { get; set; }
    }

    public class UnauthTxnListInqUnauthTxnListInqRec {
        public string UnauthTxnName { get; set; }
        public string UnauthTxnID { get; set; }
        public string UnauthTxnStat { get; set; }
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string EntryEmplNo { get; set; }
    }
}
