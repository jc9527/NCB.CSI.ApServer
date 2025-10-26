using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDCtrctCanRqValidator))]
    public class TDCtrctCanRq : EsbInqCommonRq {
        public bool? ValidateOnly { get; set; }
        public TDCtrctCanPayload Payload { get; set; }
    }
    public class TDCtrctCanPayload {
        public string ArrngId { get; set; }
        public IEnumerable<TDCtrctCanCustInfo> CustInfo { get; set; }
        public string ProdId { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public string Rsn { get; set; }
        public string SeqNo { get; set; }
        public string MainAcctNo { get; set; }
        public IEnumerable<TDCtrctCanStlInfo> StlInfo { get; set; }
        public string IPAddr { get; set; }
        public string DevNo { get; set; }
        public string GPS { get; set; }
        public string EntryDeptCode { get; set; }
        public string PrftCntr { get; set; }
        public string CostCntr { get; set; }
        public string EntryEmplNo { get; set; }
        public string AuthEmpId { get; set; }
        public string VerName { get; set; }
        public string EcoUnit { get; set; }
        public string APIKey { get; set; }
        public string MobLang { get; set; }

        public IEnumerable<TDCtrctCanOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<TDCtrctCanTxnDateRec> TxnDateRec { get; set; }
        public string Chan { get; set; }
    }
    public class TDCtrctCanCustInfo {
        public string CustId { get; set; }
        public string CustRole { get; set; }
    }
    public class TDCtrctCanStlInfo {
        public string DbAcctFlg { get; set; }
        public string CrAcctFlg { get; set; }
        public IEnumerable<TDCtrctCanRefInfo> RefInfo { get; set; }

    }
    public class TDCtrctCanRefInfo {
        public string DbAcctNo { get; set; }
        public string CrAcctNo { get; set; }
    }
    public class TDCtrctCanRqValidator : AbstractValidator<TDCtrctCanRq> {
        public TDCtrctCanRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
            //RuleFor(x => x.Payload.APIKey).NotEmpty();
        }
    }
    public class TDCtrctCanRs : EsbT24InqCommonRs {
        public TDCtrctCanHeaderInfo HeaderInfo { get; set; }
        public TDCtrctCanPayload Payload { get; set; }
    }
    public class TDCtrctCanHeaderInfo {
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public TDCtrctCanAudit Audit { get; set; }
    }
    public class TDCtrctCanAudit {
        public string T24Time { get; set; }
        public string VersionNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class TDCtrctCanOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class TDCtrctCanTxnDateRec {
        public string TxntDate { get; set; }
    }
}
