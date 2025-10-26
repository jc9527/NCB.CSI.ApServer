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
    [Validator(typeof(AcctInfoModRqValidator))]
    public class AcctInfoModRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public string ArrngId { get; set; }
        public AcctInfoModCustRecModel CustRec { get; set; }
        public string ProdName { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public string RsnCode { get; set; }
        public string MainAcctNo { get; set; }
        public AcctInfoModAcctInfoModel AcctInfo { get; set; }
        public string IPAddr { get; set; }
        public string DevNo { get; set; }
        public string GPS { get; set; }
        public string EntryDeptCode { get; set; }
        public string PrftCntr { get; set; }
        public string CostCntr { get; set; }
        public string VerName { get; set; }
        public string EcoUnit { get; set; }
        public string APIKey { get; set; }
        public string MobLang { get; set; }
    }

    public class AcctInfoModRqValidator : AbstractValidator<AcctInfoModRq> {
        public AcctInfoModRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
            RuleFor(x => x.ProdName).NotEmpty();
        }
    }

    public class AcctInfoModCustRecModel {
        public string CIFNo { get; set; }
        public string CustRole { get; set; }
    }

    public class AcctInfoModAcctInfoModel {
        public IEnumerable<AcctInfoModAcctTitl1RecModel> AcctTitl1Rec { get; set; }
        public IEnumerable<AcctInfoModAcctTitl2RecModel> AcctTitl2Rec { get; set; }
        public IEnumerable<AcctInfoModShrtTitlRecModel> ShrtTitlRec { get; set; }
        public string AcctNo { get; set; }
        public IEnumerable<AcctInfoModPostRstrctRecModel> PostRstrctRec { get; set; }
        public IEnumerable<AcctInfoModMobAcctNoRecModel> MobAcctNoRec { get; set; }
        public IEnumerable<AcctInfoModAcctOpnPurpRecModel> AcctOpnPurpRec { get; set; }
        public string CtrctType { get; set; }
        public string CtrctVer { get; set; }
        public string AppntDate { get; set; }
        public string PayrollCode { get; set; }
        public string MainAcctNo { get; set; }
        public string DgtlLvl { get; set; }
        public IEnumerable<AcctInfoModCampRecModel> CampRec { get; set; }
        public string PktAcctNo { get; set; }
        public IEnumerable<AcctInfoModAcctClsRsnRecModel> AcctClsRsnRec { get; set; }
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
        public string HdlgChrgType { get; set; }
    }

    public class AcctInfoModAcctTitl1RecModel {
        public string AcctTitl1 { get; set; }
    }

    public class AcctInfoModAcctTitl2RecModel {
        public string AcctTitl2 { get; set; }
    }

    public class AcctInfoModShrtTitlRecModel {
        public string ShrtTitl { get; set; }
    }

    public class AcctInfoModPostRstrctRecModel {
        public string PostRstrctRsnCode { get; set; }
        public string PostRstrctCode { get; set; }
        public IEnumerable<AcctInfoModPostRstrctRsnRecModel> PostRstrctRsnRec { get; set; }
        public string PostRstrctStartDate { get; set; }
        public string PostRstrctEndDate { get; set; }
        public string PostRstrctRlsCode { get; set; }
        public IEnumerable<AcctInfoModPostRstrctRlsRsnRecModel> PostRstrctRlsRsnRec { get; set; }
    }

    public class AcctInfoModPostRstrctRsnRecModel {
        public string PostRstrctRsn { get; set; }
    }

    public class AcctInfoModPostRstrctRlsRsnRecModel {
        public string PostRstrctRlsRsn { get; set; }
    }

    public class AcctInfoModMobAcctNoRecModel {
        public string MobAcctNo { get; set; }
    }

    public class AcctInfoModAcctOpnPurpRecModel {
        public string AcctOpnPurp { get; set; }
    }

    public class AcctInfoModCampRecModel {
        public string CampId { get; set; }
        public string CampExpDate { get; set; }
        public string CampIntrstRate { get; set; }
        public string CampIntrstMemo { get; set; }
    }

    public class AcctInfoModAcctClsRsnRecModel {
        public string AcctClsRsn { get; set; }
    }

    public class AcctInfoModRs : EsbT24CommonRs {
        public EsbHeaderInfo HeaderInfo { get; set; }
        public CustInfoModel CustInfo { get; set; }
        public class CustInfoModel {
            public string ArrngId { get; set; }
            public IEnumerable<AcctInfoModCustRecModel> CustRec { get; set; }
            public string ProdName { get; set; }
            public string Ccy { get; set; }
            public string EffDate { get; set; }
            public string RsnCode { get; set; }
            public string AcctRefNo { get; set; }
            public string MainAcctNo { get; set; }
            public AcctInfoModAcctInfoModel AcctInfo { get; set; }
            public IEnumerable<AcctInfoModOvrrdRecModel> OvrrdRec { get; set; }
            public IEnumerable<AcctInfoModUpdtDateRecModel> UpdtDateRec { get; set; }
            public string IPAddr { get; set; }
            public string DevNo { get; set; }
            public string GPS { get; set; }
            public string EntryDeptCode { get; set; }
            public string PrftCntr { get; set; }
            public string CostCntr { get; set; }
            public string AuthEmpId { get; set; }
            public string VerName { get; set; }
            public string EcoUnit { get; set; }
            public string APIKey { get; set; }
            public string MobLang { get; set; }
            public string Chan { get; set; }
        }
    }

    public class AcctInfoModOvrrdRecModel {
        public string Ovrrd { get; set; }
    }

    public class AcctInfoModUpdtDateRecModel {
        public string UpdtDate { get; set; }
    }
}
