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
    [Validator(typeof(DbCardTxnDtlsInqRqValidator))]
    public class DbCardTxnDtlsInqRq : EsbDebitCardInqCommonRq {
        public string InqType { get; set; }
        [LogItem("CustId")]
        public string InqKeyId { get; set; }
        public string StartTxnDate { get; set; }
        public string EndTxnDate { get; set; }
    }

    public class DbCardTxnDtlsInqRqValidator : AbstractValidator<DbCardTxnDtlsInqRq> {
        public DbCardTxnDtlsInqRqValidator() {
            RuleFor(x => x.InqType).NotEmpty();
            RuleFor(x => x.InqKeyId).NotEmpty();
            RuleFor(x => x.StartTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class DbCardTxnDtlsInqRs : EsbNonT24CommonRs {
        public IEnumerable<DbCardTxnDtlsInqCardTxnRec> CardTxnRec { get; set; }
        public DbCardTxnDtlsInqControlRec ControlRec { get; set; }
    }

    public class DbCardTxnDtlsInqCardTxnRec {
        public string CustPermId { get; set; }
        public string LockSeqId { get; set; }
        public string TxnDate { get; set; }
        public string PostDate { get; set; }
        public string Desc { get; set; }
        public string Amt { get; set; }
        public string CardNo { get; set; }
        public string CardAtt { get; set; }
        public string CustChnName { get; set; }
        public string CntryCode { get; set; }
        public string CntryCodeName { get; set; }
        public string CntryAmt { get; set; }
        public string CntryAmtCcy { get; set; }
        public string XchagDate { get; set; }
        public string TxnType { get; set; }
        public string TxnTypeName { get; set; }
        public string AuthCode { get; set; }
        public string MrchCode { get; set; }
        public string IndsyCodeName { get; set; }
        public string InstlmtCond { get; set; }
        public string InstlmtRsltCode { get; set; }
        public string InstlmtRsltMsg { get; set; }
        public string LoanBal { get; set; }
        public string InstlmtFlg { get; set; }
        public string PrcDate { get; set; }
        public string FeeAmt { get; set; }
    }

    public class DbCardTxnDtlsInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
