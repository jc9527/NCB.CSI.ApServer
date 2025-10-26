using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDCtrctContModRqValidator))]
    public class TDCtrctContModRq : EsbInqCommonRq {
        public bool? ValidateOnly { get; set; }
        public TDCtrctContModPayload Payload { get; set; }
    }
    public class TDCtrctContModPayload {
        public string ArrngId { get; set; }
        public IEnumerable<TDCtrctContModCustInfo> CustInfo { get; set; }
        public string ProdId { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public string Rsn { get; set; }
        public string SeqNo { get; set; }
        public string MainAcctNo { get; set; }
        public TDCtrctContModScheInfo ScheInfo { get; set; }
        public TDCtrctContModRenewInfo RenewInfo { get; set; }
        public TDCtrctContModCmmtmntInfo CmmtmntInfo { get; set; }
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
        public IEnumerable<TDCtrctContModOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<TDCtrctContModTxnDateRec> MyProperty { get; set; }
        public string Chan { get; set; }
    }
    public class TDCtrctContModCustInfo {
        public string CustId { get; set; }
        public string CustRole { get; set; }
    }
    public class TDCtrctContModScheInfo {
        public IEnumerable<TDCtrctContModPmtInfo> PmtInfo { get; set; }
    }
    public class TDCtrctContModPmtInfo {
        public string MtrtyInstrct { get; set; }
    }
    public class TDCtrctContModRenewInfo {
        public string RenewPrd { get; set; }
        public string RenewDateType { get; set; }
        public string RenewDate { get; set; }
        public string RenewType { get; set; }
    }
    public class TDCtrctContModCmmtmntInfo {
        public string Amt { get; set; }
        public string Fee { get; set; }
        public string Term { get; set; }
        public string MtrtyDate { get; set; }
        public string TDAutoRollOvrFlg { get; set; }
        public string LmtModFlg { get; set; }
    }
    public class TDCtrctContModRqValidator : AbstractValidator<TDCtrctContModRq> {
        public TDCtrctContModRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
            //RuleFor(x => x.Payload.ArrngId).NotEmpty();
            //RuleFor(x => x.Payload.ProdId).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewPrd).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewDateType).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            //RuleFor(x => x.Payload.RenewInfo.RenewType).NotEmpty();
            //RuleFor(x => x.Payload.CmmtmntInfo.Term).NotEmpty();
            //RuleFor(x => x.Payload.CmmtmntInfo.MtrtyDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }
    public class TDCtrctContModRs : EsbT24InqCommonRs {
        public TDCtrctContModHeaderInfo HeaderInfo { get; set; }
        public TDCtrctContModPayload Payload { get; set; }
    }
    public class TDCtrctContModHeaderInfo {
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public TDCtrctContModAudit Audit { get; set; }
    }
    public class TDCtrctContModAudit {
        public string T24Time { get; set; }
        public string VersionNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class TDCtrctContModOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class TDCtrctContModTxnDateRec {
        public string TxntDate { get; set; }
    }
}
