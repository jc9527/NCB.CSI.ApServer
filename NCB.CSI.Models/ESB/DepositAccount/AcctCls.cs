using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(AcctClsRqValidator))]
    public class AcctClsRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public string ArrngId { get; set; }
        public IEnumerable<AcctClsCustRec> CustRec { get; set; }
        public string ProdName { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public string RsnCode { get; set; }
        public string AcctRefNo { get; set; }
        public string MainAcctNo { get; set; }
        public IEnumerable<AcctClsSettlemInfo> SettlemInfo { get; set; }
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

    public class AcctClsCustRec {
        public string CIFNo { get; set; }
        public string CustRole { get; set; }
    }

    public class AcctClsSettlemInfo {
        public string CrAcctFlg { get; set; }
        public IEnumerable<AcctClsRefInfo> RefInfo { get; set; }
    }

    public class AcctClsRefInfo {
        public string CrAcctNo { get; set; }
    }

    public class AcctClsRqValidator : AbstractValidator<AcctClsRq> {
        public AcctClsRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty();
            RuleFor(x => x.ProdName).NotEmpty();
            RuleFor(x => x.SettlemInfo).NotEmpty();
        }
    }

    public class AcctClsRs : EsbT24CommonRs {
        public AcctClsRsHeaderInfo HeaderInfo { get; set; }
        public AcctClsRsAcctClsInfo AcctClsInfo { get; set; }
    }

    public class AcctClsRsAcctClsInfo {
        public string ArrngId { get; set; }
        public IEnumerable<AcctClsCustRec> CustRec { get; set; }
        public string ProdName { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public string RsnCode { get; set; }
        public string AcctRefNo { get; set; }
        public string MainAcctNo { get; set; }
        public IEnumerable<AcctClsSettlemInfo> SettlemInfo { get; set; }
        public IEnumerable<AcctClsRsOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<AcctClsRsUpdtDateRec> UpdtDateRec { get; set; }
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

    public class AcctClsRsHeaderInfo {
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public EsbAudit Audit { get; set; }
    }

    public class AcctClsRsOvrrdRec {
        public string Ovrrd { get; set; }
    }

    public class AcctClsRsUpdtDateRec {
        public string UpdtDate { get; set; }
    }
}
