using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(NPDLmtModRqValidator))]
    public class NPDLmtModRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public NPDLmtModPayload Payload { get; set; }
    }
    public class NPDLmtModPayload {
        public string ArrngId { get; set; }
        public IEnumerable<NPDLmtModCustInfo> CustInfo { get; set; }
        public string ProdId { get; set; }
        public string ProdVar { get; set; }
        public string Ccy { get; set; }
        public string BnfType { get; set; }
        public string BnfCamoId { get; set; }
        public IEnumerable<NPDLmtModAgntInfo> AgntInfo { get; set; }
        public string RwdPntsArrngId { get; set; }
        public string TxnDate { get; set; }
        public string TxnName { get; set; }
        public string EffDate { get; set; }
        public string Rsn { get; set; }
        public string SeqNo { get; set; }
        public string AcctNo { get; set; }
        public NPDLmtModArrngRulesInfo ArrngRulesInfo { get; set; }
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
    public class NPDLmtModCustInfo {
        public string CustId { get; set; }
        public string CustRole { get; set; }
    }
    public class NPDLmtModAgntInfo {
        public string Agnt { get; set; }
        public string AgntArrngId { get; set; }
        public string AgntRole { get; set; }
    }
    public class NPDLmtModArrngRulesInfo {
        public IEnumerable<NPDLmtModRuleInfo> RuleInfo { get; set; }
    }
    public class NPDLmtModRuleInfo {
        public string RuleName { get; set; }
        public string PrdcAttr { get; set; }
        public string BalType { get; set; }
        public string PrdcVal1 { get; set; }
        public string PrdcVal2 { get; set; }
        public string PrdcVal3 { get; set; }
        public IEnumerable<NPDLmtModActvty> Actvty { get; set; }
    }
    public class NPDLmtModActvty {
        public string ActvtyClss { get; set; }
        public string ActvtyId { get; set; }
    }
    public class NPDLmtModRqValidator : AbstractValidator<NPDLmtModRq> {
        public NPDLmtModRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
            //RuleFor(x => x.Payload.ArrngId).NotEmpty();
            //RuleFor(x => x.Payload.ArrngRulesInfo).NotEmpty();
            //RuleFor(x => x.Payload.ArrngRulesInfo.RuleInfo).NotEmpty();
            //RuleFor(x => x.Payload.ArrngRulesInfo.RuleInfo.Select(y => y.PrdcVal1)).NotEmpty();
            //RuleFor(x => x.Payload.ArrngRulesInfo.RuleInfo.Select(y => y.PrdcVal2)).NotEmpty();
            //RuleFor(x => x.Payload.ArrngRulesInfo.RuleInfo.Select(y => y.PrdcVal3)).NotEmpty();
        }
    }
    public class NPDLmtModRs : EsbNonT24CommonRs {
        public EsbHeaderInfo HeaderInfo { get; set; }
        public NPDLmtModNPDLmtModInfo NPDLmtModInfo { get; set; }
    }
    public class NPDLmtModNPDLmtModInfo {
        public string ArrngId { get; set; }
        public IEnumerable<NPDLmtModCustInfo> CustInfo { get; set; }
        public string ProdId { get; set; }
        public string ProdVar { get; set; }
        public string Ccy { get; set; }
        public string BnfType { get; set; }
        public string BnfCamoId { get; set; }
        public IEnumerable<NPDLmtModAgntInfo> AgntInfo { get; set; }
        public string RwdPntsArrngId { get; set; }
        public string TxnDate { get; set; }
        public string TxnName { get; set; }
        public string EffDate { get; set; }
        public string Rsn { get; set; }
        public string SeqNo { get; set; }
        public string AcctNo { get; set; }
        public NPDLmtModArrngRulesInfo ArrngRulesInfo { get; set; }
        public IEnumerable<NPDLmtModOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<NPDLmtModTxnDateRec> TxnDateRec { get; set; }
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
    public class NPDLmtModOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class NPDLmtModTxnDateRec {
        public string TxntDate { get; set; }
    }
}
