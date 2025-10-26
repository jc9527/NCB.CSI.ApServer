using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.CurrentAccount {
    [Validator(typeof(CampIntrstRateModRqValidator))]
    public class CampIntrstRateModRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public string ArrngId { get; set; }
        public IEnumerable<CampIntrstRateModCustRec> CustRec { get; set; }
        public string ProdName { get; set; }
        public string Ccy { get; set; }
        public string TxnType { get; set; }
        public string EffDate { get; set; }
        public string RsnCode { get; set; }
        public string AcctRefNo { get; set; }
        public string MainAcctNo { get; set; }
        public IEnumerable<CampIntrstRateModAcctInfo> AcctInfo { get; set; }
        public IEnumerable<CampIntrstRateModMarginRuleRec> MarginRuleRec { get; set; }
        public IEnumerable<CampIntrstRateModAcctRateInfo> AcctRateInfo { get; set; }
        public CampIntrstRateModPktAcctRateInfo PktAcctRateInfo { get; set; }
        public CampIntrstRateModIntrstRec IntrstRec { get; set; }
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
    }
    public class CampIntrstRateModCustRec { 
        public string CIFNo { get; set; }
        public string CustRole { get; set; }
    }
    public class CampIntrstRateModAcctInfo {  
        public CampIntrstRateModAcctTitl1Rec AcctTitl1Rec { get; set; }
        public IEnumerable<CampIntrstRateModAcctTitl2Rec> AcctTitl2Rec { get; set; }
        public IEnumerable<CampIntrstRateModShrtTitlRec> ShrtTitlRec { get; set; }
        public string AcctNo { get; set; }
        public IEnumerable<CampIntrstRateModPostRstrctRec> PostRstrctRec { get; set; }
        public IEnumerable<CampIntrstRateModAcctNoRec> MobAcctNoRec { get; set; }
        public IEnumerable<CampIntrstRateModAcctOpnPurpRec> AcctOpnPurpRec { get; set; }
        public string CtrctType { get; set; }
        public string CtrctVer { get; set; }
        public string AppntDate { get; set; }
        public string PayrollCode { get; set; }
        public string MainAcctNo { get; set; }
        public string DgtlLvl { get; set; }
        public IEnumerable<CampIntrstRateModMobCampRec> CampRec { get; set; }
        public string PktAcctNo { get; set; }
        public IEnumerable<CampIntrstRateModMobAcctClsRsnRec> AcctClsRsnRec { get; set; }
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
        public string OvrdChrgFlg { get; set; }
        public string NPLStat { get; set; }
        public string NPLUnpaidTerm { get; set; }
        public string NPLPaidTerm { get; set; }
        public string NPLPaidFlag { get; set; }
        public string ODRate { get; set; }
        public string ORRepmtDay { get; set; }
        public string ODRepmtType { get; set; }
    }
    public class CampIntrstRateModAcctTitl1Rec { 
        public string AcctTitl1 { get; set; }
    }
    public class CampIntrstRateModAcctTitl2Rec { 
        public string AcctTitl2 { get; set; }
    }
    public class CampIntrstRateModShrtTitlRec { 
        public string ShrtTitl { get; set; }
        public string AcctNo { get; set; }
        public CampIntrstRateModPostRstrctRec PostRstrctRec { get; set; }
        public IEnumerable<CampIntrstRateModAcctNoRec> MobAcctNoRec { get; set; }

    }
    public class CampIntrstRateModPostRstrctRec { 
        public string PostRstrct { get; set; }
        public string PostRstrctCode { get; set; }
        public IEnumerable<CampIntrstRateModPostRstrctRsnRec> PostRstrctRsnRec { get; set; }
        public string PostRstrctStartDate { get; set; }
        public string PostRstrctEndDate { get; set; }
        public string PostRstrctRlsCode { get; set; }
        public IEnumerable<CampIntrstRateModPostRstrctRlsRsnRec> PostRstrctRlsRsnRec { get; set; }
    }
    public class CampIntrstRateModPostRstrctRsnRec { 
        public string PostRstrctRsn { get; set; }
    }
    public class CampIntrstRateModPostRstrctRlsRsnRec { 
        public string PostRstrctRlsRsn { get; set; }
    }
    public class CampIntrstRateModAcctNoRec { public string MobAcctNo { get; set; } }
    public class CampIntrstRateModAcctOpnPurpRec { public string AcctOpnPurp { get; set; } }
    public class CampIntrstRateModMobCampRec { 
        public string CampId { get; set; }
        public string CampExpDate { get; set; }
        public string CampInstrstType { get; set; }
        public string CampIntrstMemo { get; set; }
    }
    public class CampIntrstRateModMobAcctClsRsnRec {
        public string AcctClsRsn { get; set; }
    }
    public class CampIntrstRateModMarginRuleRec {
        public string AcctMinBal { get; set; }
    }
    public class CampIntrstRateModAcctRateInfo {  
        public string TierType { get; set; }
        public IEnumerable<CampIntrstRateModRateInfo> RateInfo { get; set; }
    }
    public class CampIntrstRateModRateInfo {
        public string FixRate { get; set; }
        public string FltRate { get; set; }
        public string MrgnRateFlg { get; set; }
        public IEnumerable<CampIntrstRateModMrgnInfo> MrgnInfo { get; set; }
        public string MaxTierRate { get; set; }
        public string MinTierRate { get; set; }
        public string EffRate { get; set; }
        public string TierAmt { get; set; }
        public string NegTierRate { get; set; }
        public string Pct { get; set; }
    }
    public class CampIntrstRateModMrgnInfo {  
        public string MrgnType { get; set; }
        public string MrgnOperType { get; set; }
        public string MrgnRateAdd { get; set; }
    }
    public class CampIntrstRateModPktAcctRateInfo {
        public string TierType { get; set; }
        public IEnumerable<CampIntrstRateModRateInfo> RateInfo { get; set; }
    }
    public class CampIntrstRateModIntrstRec {
        public IEnumerable<CampIntrstRateModIntrstTypeRec> IntrstTypeRec { get; set; }
    }
    public class CampIntrstRateModIntrstTypeRec {
        public string IntrstType { get; set; }
        public string IntrstMthd { get; set; }
        public IEnumerable<CampIntrstRateModIntrstPropRec> IntrstPropRec { get; set; }
        public string IntrstFreq { get; set; }
        public IEnumerable<CampIntrstRateModIntrstDateRec> IntrstDateRec { get; set; }
    }
    public class CampIntrstRateModIntrstPropRec {
        public string IntrstId { get; set; }
    }
    public class CampIntrstRateModIntrstDateRec {
        public string StartDate { get; set; }
    }

    public class CampIntrstRateModRqValidator : AbstractValidator<CampIntrstRateModRq> {
        public CampIntrstRateModRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
            RuleFor(x => x.ProdName).NotEmpty();
            RuleFor(x => x.TxnType).NotEmpty();
        }
    }
    public class CampIntrstRateModRs : EsbT24CommonRs {
        public EsbHeaderInfo HeaderInfo { get; set; }
        public CampIntrstRateModRsrvdAcctNoInfo RsrvdAcctNoInfo { get; set; }
    }
    public class CampIntrstRateModRsrvdAcctNoInfo {  
        public string ArrngId { get; set; }
        public IEnumerable<CampIntrstRateModCustRec> CustRec { get; set; }
        public string ProdName { get; set; }
        public string Ccy { get; set; }
        public string TxnType { get; set; }
        public string EffDate { get; set; }
        public string RsnCode { get; set; }
        public string AcctRefNo { get; set; }
        public string MainAcctNo { get; set; }
        public CampIntrstRateModAcctInfo AcctInfo { get; set; }
        public IEnumerable<CampIntrstRateModMarginRuleRec> MarginRuleRec { get; set; }
        public CampIntrstRateModAcctRateInfo AcctRateInfo { get; set; }
        public CampIntrstRateModPktAcctRateInfo PktAcctRateInfo { get; set; }
        public IEnumerable<CampIntrstRateModIntrstRec> IntrstRec { get; set; }
        public IEnumerable<CampIntrstRateModOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<CampIntrstRateModUpdtDateRec> UpdtDateRec { get; set; }
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
    public class CampIntrstRateModOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class CampIntrstRateModUpdtDateRec {
        public string UpdtDate { get; set; }
    }
}
