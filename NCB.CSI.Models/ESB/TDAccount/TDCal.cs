using FluentValidation;
using FluentValidation.Attributes;
using FluentValidation.Internal;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDCalRqValidator))]
    public class TDCalRq : EsbInqCommonRq {
        public bool? ValidateOnly { get; set; }
        public TDCalPayload Payload { get; set; }
    }
    public class TDCalPayload { 
        public string ArrngId { get; set; }
        public IEnumerable<TDCalCustInfo> CustInfo { get; set; }
        public string ProdId { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public string SimRefNo { get; set; }
        public string Rsn { get; set; }
        public TDCalAcctInfo AcctInfo { get; set; }
        public TDCalCmmtmntInfo CmmtmntInfo { get; set; }
        public TDCalTDRateInfo TDRateInfo { get; set; }
        public TDCalRenewInfo RenewInfo { get; set; }
        public IEnumerable<TDCalStlInfo> StlInfo { get; set; }
        public TDCalOvrrdRec OvrrdRec { get; set; }
        public TDCalTxnDateRec TxnDateRec { get; set; }
        public TDCalScheInfo ScheInfo { get; set; }
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
    public class TDCalAcctInfo {  
        public IEnumerable<TDCalAcctTitl1Rec> AcctTitl1Rec { get; set; }
        public IEnumerable<TDCalAcctTitl2Rec> AcctTitl2Rec { get; set; }
        public IEnumerable<TDCalShrtTitlRec> ShrtTitlRec { get; set; }
        public string AcctNo { get; set; }
        public IEnumerable<TDCalPostRstrctRec> PostRstrctRec { get; set; }
        public IEnumerable<TDCalMobAcctNoRec> MobAcctNoRec { get; set; }
        public IEnumerable<TDCalAcctOpnPurpRec> AcctOpnPurpRec { get; set; }
        public string CtrctType { get; set; }
        public string CtrctVer { get; set; }
        public string AppntDate { get; set; }
        public string PayrollCode { get; set; }
        public string MainAcctNo { get; set; }
        public string DgtlLvl { get; set; }
        public IEnumerable<TDCalCampRec> CampRec { get; set; }
        public string PktAcctNo { get; set; }
        public IEnumerable<TDCalAcctClsRsnRec> AcctClsRsnRec { get; set; }
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
    public class TDCalAcctTitl1Rec { 
        public string AcctTitl1 { get; set; }
    }
    public class TDCalAcctTitl2Rec { 
        public string AcctTitl2 { get; set; }
    }
    public class TDCalShrtTitlRec { 
        public string ShrtTitl { get; set; }
    }
    public class TDCalPostRstrctRec { 
        public string PostRstrctCode { get; set; }
        public IEnumerable<TDCalPostRstrctRsnRec> PostRstrctRsnRec { get; set; }
        public string PostRstrctStartDate { get; set; }
        public string PostRstrctEndDate { get; set; }
        public string PostRstrctRlsCode { get; set; }
        public IEnumerable<TDCalPostRstrctRlsRsnRec> PostRstrctRlsRsnRec { get; set; }

    }
    public class TDCalPostRstrctRsnRec { 
        public string PostRstrctRsn { get; set; }
    }
    public class TDCalPostRstrctRlsRsnRec { 
        public string PostRstrctRlsRsn { get; set; }
    }
    public class TDCalMobAcctNoRec { 
        public string TDCalMobAcctNo { get; set; }
    }
    public class TDCalAcctOpnPurpRec { 
        public string AcctOpnPurp { get; set; }
    }
    public class TDCalCampRec { 
        public string CampId { get; set; }
        public string CampExpDate { get; set; }
        public string CampInstrstType { get; set; }
        public string CampIntrstMemo { get; set; }
    }
    public class TDCalAcctClsRsnRec {
        public string AcctClsRsn { get; set; }
    }
    public class TDCalCmmtmntInfo { 
        public string Amt { get; set; }
        public string Fee { get; set; }
        public string Term { get; set; }
        public string MtrtyDate { get; set; }
        public string TDAutoRollOvrFlg { get; set; }
        public string LmtModFlg { get; set; }
    }
    public class TDCalCustInfo { 
        public string CustId { get; set; }
        public string CustRole { get; set; }
    }
    public class TDCalTDRateInfo {  
        public string FltRateFlg { get; set; }
        public IEnumerable<TDCalRateInfo> RateInfo { get; set; }
        public string TierType { get; set; }
    }
    public class TDCalRateInfo { 
        public string FixRate { get; set; }
        public string FltRate { get; set; }
        public string MrgnRateFlg { get; set; }
        public IEnumerable<TDCalMrgnInfo> MrgnInfo { get; set; }
        public string MaxTierRate { get; set; }
        public string MinTierRate { get; set; }
        public string EffRate { get; set; }
        public string TierAmt { get; set; }
        public string NegTierRate { get; set; }
        public string Pct { get; set; }
    }
    public class TDCalMrgnInfo { 
        public string MrgnType { get; set; }
        public string MrgnOperType { get; set; }
        public string MrgnRateAdd { get; set; }
    }
    public class TDCalRenewInfo {  
        public string RenewPrd { get; set; }
        public string RenewDateType { get; set; }
        public string RenewType { get; set; }
    }
    public class TDCalStlInfo {  
        public string DbAcctFlg { get; set; }
        public string CrAcctFlg { get; set; }
        public IEnumerable<TDCalRefInfo> RefInfo { get; set; }
    }
    public class TDCalRefInfo { 
        public string DbAcctNo { get; set; }
        public string CrAcctNo { get; set; }
    }
    public class TDCalScheInfo {  
        public IEnumerable<TDCalPmtInfo> PmtInfo { get; set; }
    }
    public class TDCalPmtInfo { 
        public string MtrtyInstrct { get; set; }
    }
    public class TDCalRqValidator : AbstractValidator<TDCalRq> {
        public TDCalRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
            //RuleFor(x => x.Payload.CustInfo).NotEmpty();
            //RuleFor(x => x.Payload.ProdId).NotEmpty();
            //RuleFor(x => x.Payload.EffDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            //RuleFor(x => x.Payload.CmmtmntInfo).NotEmpty();
            //RuleFor(x => x.Payload.CmmtmntInfo.Amt).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewPrd).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewDateType).NotEmpty();
            //RuleFor(x => x.Payload.RenewInfo.RenewType).NotEmpty();
            //RuleFor(x => x.Payload.StlInfo).NotEmpty();
            //RuleFor(x => x.Payload.StlInfo.Select(y=>y.DbAcctFlg)).NotEmpty();
            //RuleFor(x => x.Payload.StlInfo.Select(y => y.DbAcctFlg)).NotEmpty();
        }
    }
    public class TDCalRs : EsbT24InqCommonRs {
        public TDCalHeaderInfo HeaderInfo { get; set; }
        public TDCalPayload Payload { get; set; }

    }
    public class TDCalHeaderInfo { 
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public TDCalAudit Audit { get; set; }


    }
    public class TDCalAudit {  
        public string T24Time { get; set; }
        public string VersionNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class TDCalOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class TDCalTxnDateRec {
        public string TxntDate { get; set; }
    }
}
