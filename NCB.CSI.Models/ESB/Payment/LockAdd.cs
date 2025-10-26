using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Payment {
    [Validator(typeof(LockAddRqValidator))]
    public class LockAddRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public string TxnType { get; set; }
        public string LockSeqNo { get; set; }
        public LockAddLockInfo LockInfo { get; set; }
    }

    [Validator(typeof(LockAddLockInfoValidator))]
    public class LockAddLockInfo {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public string LockRsn { get; set; }
        public string StartTxnDate { get; set; }
        public string EndTxnDate { get; set; }
        public string LockAmt { get; set; }
        public string LockCode { get; set; }
        public IEnumerable<LockAddOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<LockAddUpdtDateRec> UpdtDateRec { get; set; }
        public string LockType { get; set; }
        public string IPAddr { get; set; }
        public string DevNo { get; set; }
        public string GPS { get; set; }
        public string EntryDeptCode { get; set; }
        public string PrftCntr { get; set; }
        public string CostCntr { get; set; }
        public string AuthEmpId { get; set; }
        public string EntryEmplNo { get; set; }
        public string VerName { get; set; }
        public string EcoUnit { get; set; }
        public string APIKey { get; set; }
        public string MobLang { get; set; }
        public string Chan { get; set; }
    }
    public class LockAddOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class LockAddUpdtDateRec {
        public string UpdtDate { get; set; }
    }
    public class LockAddRqValidator : AbstractValidator<LockAddRq> {
        public LockAddRqValidator() {
            RuleFor(x => x.TxnType).NotEmpty();
        }
    }
    public class LockAddLockInfoValidator : AbstractValidator<LockAddLockInfo> {
        public LockAddLockInfoValidator() {
            RuleFor(x => x.AcctNo).NotEmpty();
            RuleFor(x => x.LockAmt).NotEmpty();
            RuleFor(x => x.LockType).NotEmpty();
        }
    }

    public class LockAddRs : EsbT24CommonRs {
        public LockAddHeaderInfo HeaderInfo { get; set; }
        public LockAddLockInfo LockInfo { get; set; }
    }
    public class LockAddHeaderInfo {
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public LockAddAudit Audit { get; set; }
    }
    public class LockAddAudit {
        public string T24Time { get; set; }
        public string VersionNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
}
