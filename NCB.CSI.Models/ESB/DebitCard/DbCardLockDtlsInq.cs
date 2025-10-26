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

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(DbCardLockDtlsInqRqValidator))]
    public class DbCardLockDtlsInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string StartCfgDate { get; set; }
        public string EndCfgDate { get; set; }
    }

    public class DbCardLockDtlsInqRqValidator : AbstractValidator<DbCardLockDtlsInqRq> {
        public DbCardLockDtlsInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
            RuleFor(x => x.StartCfgDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndCfgDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class DbCardLockDtlsInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardLockDtlsInqCardLockRec> CardLockRec { get; set; }
        public DbCardLockDtlsInqControlRec ControlRec { get; set; }
    }

    public class DbCardLockDtlsInqCardLockRec {
        public string CustPermId { get; set; }
        public string CardNo { get; set; }
        public string CardAtt { get; set; }
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string Amt { get; set; }
        public string BlkAmt { get; set; }
        public string IndsyCode { get; set; }
        public string IndsyCodeName { get; set; }
        public string TxnType { get; set; }
        public string ReqPmtDays { get; set; }
        public string AuthCode { get; set; }
        public string MrchCode { get; set; }
        public string CntryCode { get; set; }
        public string MrchNo { get; set; }
        public string PosEntryType { get; set; }
        public string IsoRtrnCode { get; set; }
        public string IsoRtrnDesc { get; set; }
        public string UnlockFlg { get; set; }
        public string ReqPmtFlg { get; set; }
        public string LockSeqNo { get; set; }
    }

    public class DbCardLockDtlsInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
