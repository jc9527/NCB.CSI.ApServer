using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDAcctOpnCalInqRqValidator))]
    public class TDAcctOpnCalInqRq : EsbInqCommonRq {
        public bool? ValidateOnly { get; set; }
        public TDAcctOpnCalInqPayload Payload { get; set; }
    }
    public class TDAcctOpnCalInqPayload {
        public string ArrngId { get; set; }
        public IEnumerable<TDAcctOpnCalInqCustInfo> CustInfo { get; set; }
        public string SimRefNo { get; set; }
        public string ProdId { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public string Rsn { get; set; }
        public TDAcctOpnCalInqAcctInfo AcctInfo { get; set; }
        public TDAcctOpnCalInqCmmtmntInfo CmmtmntInfo { get; set; }
        public TDAcctOpnCalInqTDRateInfo TDRateInfo { get; set; }
        public TDAcctOpnCalInqRenewInfo RenewInfo { get; set; }
        public IEnumerable<TDAcctOpnCalInqStlInfo> StlInfo { get; set; }
        public TDAcctOpnCalInqOvrrdRec OvrrdRec { get; set; }
        public TDAcctOpnCalInqTxnDateRec TxnDateRec { get; set; }
        public TDAcctOpnCalInqScheInfo ScheInfo { get; set; }
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
        public string Chan { get; set; }
    }
    public class TDAcctOpnCalInqAcctInfo {
        public IEnumerable<TDAcctOpnCalInqAcctTitl1Rec> AcctTitl1Rec { get; set; }
        public IEnumerable<TDAcctOpnCalInqAcctTitl2Rec> AcctTitl2Rec { get; set; }
        public IEnumerable<TDAcctOpnCalInqShrtTitlRec> ShrtTitlRec { get; set; }
        public string AcctNo { get; set; }
        public IEnumerable<TDAcctOpnCalInqPostRstrctRec> PostRstrctRec { get; set; }
        public IEnumerable<TDAcctOpnCalInqMobAcctNoRec> MobAcctNoRec { get; set; }
        public IEnumerable<TDAcctOpnCalInqAcctOpnPurpRec> AcctOpnPurpRec { get; set; }
        public string CtrctType { get; set; }
        public string CtrctVer { get; set; }
        public string AppntDate { get; set; }
        public string PayrollCode { get; set; }
        public string MainAcctNo { get; set; }
        public string DgtlLvl { get; set; }
        public IEnumerable<TDAcctOpnCalInqCampRec> CampRec { get; set; }
        public string PktAcctNo { get; set; }
        public IEnumerable<TDAcctOpnCalInqAcctClsRsnRec> AcctClsRsnRec { get; set; }
        public string Term { get; set; }
        public string GLTerm { get; set; }
        public string ScoreSrc1 { get; set; }
        public string ScoreSrc2 { get; set; }
        public string ScoreSrc3 { get; set; }
        public string Score1 { get; set; }
        public string Score2 { get; set; }
        public string Score3 { get; set; }
        public string ScoreDate { get; set; }
        public string LoanPurp { get; set; }
        public string OvrdUsage { get; set; }
        public string OvrdType { get; set; }
        public string DebtNegType { get; set; }
        public string PrjoExclFlag { get; set; }
        public string GovProjLoanType { get; set; }
        public string OvrdIntrstDate { get; set; }
        public string OvrdChrgMemo { get; set; }
        public string NPLStat { get; set; }
        public string NPLUnpaidTerm { get; set; }
        public string NPLPaidTerm { get; set; }
        public string NPLPaidMemo { get; set; }
        public string ODRate { get; set; }
        public string ORRepmtDay { get; set; }
        public string ODRepmtType { get; set; }

    }
    public class TDAcctOpnCalInqAcctTitl1Rec {
        public string AcctTitl1 { get; set; }
    }
    public class TDAcctOpnCalInqAcctTitl2Rec {
        public string AcctTitl2 { get; set; }
    }
    public class TDAcctOpnCalInqShrtTitlRec {
        public string ShrtTitl { get; set; }
    }
    public class TDAcctOpnCalInqPostRstrctRec {
        public string PostRstrctCode { get; set; }
        public IEnumerable<TDAcctOpnCalInqPostRstrctRsnRec> PostRstrctRsnRec { get; set; }
        public string PostRstrctStartDate { get; set; }
        public string PostRstrctEndDate { get; set; }
        public string PostRstrctRlsCode { get; set; }
        public IEnumerable<TDAcctOpnCalInqPostRstrctRlsRsnRec> PostRstrctRlsRsnRec { get; set; }

    }
    public class TDAcctOpnCalInqPostRstrctRsnRec {
        public string PostRstrctRsn { get; set; }
    }
    public class TDAcctOpnCalInqPostRstrctRlsRsnRec {
        public string PostRstrctRlsRsn { get; set; }
    }
    public class TDAcctOpnCalInqMobAcctNoRec {
        public string TDAcctOpnCalInqMobAcctNo { get; set; }
    }
    public class TDAcctOpnCalInqAcctOpnPurpRec {
        public string AcctOpnPurp { get; set; }
    }
    public class TDAcctOpnCalInqCampRec {
        public string CampId { get; set; }
        public string CampExpDate { get; set; }
        public string CampInstrstType { get; set; }
        public string CampIntrstMemo { get; set; }
    }
    public class TDAcctOpnCalInqAcctClsRsnRec {
        public string AcctClsRsn { get; set; }
    }
    public class TDAcctOpnCalInqCmmtmntInfo {
        public string Amt { get; set; }
        public string Fee { get; set; }
        public string Term { get; set; }
        public string MtrtyDate { get; set; }
        public string TDAutoRollOvrFlg { get; set; }
        public string LmtModFlg { get; set; }
    }
    public class TDAcctOpnCalInqCustInfo {
        public string CustId { get; set; }
        public string CustRole { get; set; }
    }
    public class TDAcctOpnCalInqTDRateInfo {
        public string FltRateFlg { get; set; }
        public IEnumerable<TDAcctOpnCalInqRateInfo> RateInfo { get; set; }
        public string TierType { get; set; }
    }
    public class TDAcctOpnCalInqRateInfo {
        public string FixRate { get; set; }
        public string FltRate { get; set; }
        public string MrgnRateFlg { get; set; }
        public IEnumerable<TDAcctOpnCalInqMrgnInfo> MrgnInfo { get; set; }
        public string MaxTierRate { get; set; }
        public string MinTierRate { get; set; }
        public string EffRate { get; set; }
        public string TierAmt { get; set; }
        public string NegTierRate { get; set; }
        public string Pct { get; set; }
    }
    public class TDAcctOpnCalInqMrgnInfo {
        public string MrgnType { get; set; }
        public string MrgnOperType { get; set; }
        public string MrgnRateAdd { get; set; }
    }
    public class TDAcctOpnCalInqRenewInfo {
        public string RenewPrd { get; set; }
        public string RenewDateType { get; set; }
        public string RenewType { get; set; }
    }
    public class TDAcctOpnCalInqStlInfo {
        public string DbAcctFlg { get; set; }
        public string CrAcctFlg { get; set; }
        public IEnumerable<TDAcctOpnCalInqRefInfo> RefInfo { get; set; }
    }
    public class TDAcctOpnCalInqRefInfo {
        public string DbAcctNo { get; set; }
        public string CrAcctNo { get; set; }
    }
    public class TDAcctOpnCalInqScheInfo {
        public IEnumerable<TDAcctOpnCalInqPmtInfo> PmtInfo { get; set; }
    }
    public class TDAcctOpnCalInqPmtInfo {
        public string MtrtyInstrct { get; set; }
    }
    public class TDAcctOpnCalInqRqValidator : AbstractValidator<TDAcctOpnCalInqRq> {
        public TDAcctOpnCalInqRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
            //RuleFor(x => x.Payload.ProdId).NotEmpty();
            //RuleFor(x => x.Payload.EffDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            //RuleFor(x => x.Payload.CmmtmntInfo).NotEmpty();
            //RuleFor(x => x.Payload.CmmtmntInfo.Amt).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewPrd).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewDateType).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewType).NotEmpty();
            //RuleFor(x => x.Payload.StlInfo).NotEmpty();
            //RuleFor(x => x.Payload.StlInfo.Select(y => y.DbAcctFlg)).NotEmpty();
            //RuleFor(x => x.Payload.StlInfo.Select(y => y.DbAcctFlg)).NotEmpty();
        }
    }
    public class TDAcctOpnCalInqRs : EsbT24InqCommonRs {
        public TDAcctOpnCalInqHeaderInfo HeaderInfo { get; set; }
        public TDAcctOpnCalInqTDCalInqRec TDCalInqRec { get; set; }
        public TDAcctOpnCalInqPayload Payload { get; set; }
    }
    public class TDAcctOpnCalInqHeaderInfo {
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public TDAcctOpnCalInqAudit Audit { get; set; }
    }
    public class TDAcctOpnCalInqAudit {
        public string T24Time { get; set; }
        public string VersionNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class TDAcctOpnCalInqOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class TDAcctOpnCalInqTxnDateRec {
        public string TxntDate { get; set; }
    }
    public class TDAcctOpnCalInqTDCalInqRec {
        public string ArrngId { get; set; }
        public TDCalInqInfoTDAcctOpnCalInq TDAcctOpnCalInq { get; set; }
    }
    public class TDCalInqInfoTDAcctOpnCalInq {
        public string SimDate { get; set; }
        public string TtlDueAmt { get; set; }
        public string IntrstAmt { get; set; }
        public string PrncplAmt { get; set; }
        public string CurPrdIntrstAmt { get; set; }
        public string IntrstRate { get; set; }
        public string HdlgChrg { get; set; }
        public string WHTAmt { get; set; }
        public string TtlIntrstAmt { get; set; }
        public string OutstndAmt { get; set; }
    }
}

