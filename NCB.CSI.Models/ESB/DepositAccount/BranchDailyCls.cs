using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(BranchDailyClsRqValidator))]
    public class BranchDailyClsRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public string CoCode { get; set; }
        public BranchDailyClsPayload Payload { get; set; }
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

    public class BranchDailyClsRqValidator : AbstractValidator<BranchDailyClsRq> {
        public BranchDailyClsRqValidator() {
            RuleFor(x => x.CoCode).NotEmpty();
            RuleFor(x => x.Payload).NotEmpty();
        }
    }

    [Validator(typeof(BranchDailyClsPayloadValidator))]
    public class BranchDailyClsPayload {
        public string ClsFlg { get; set; }
        public string BussDate { get; set; }
        public string BranchStat { get; set; }
        public IEnumerable<BranchDailyClsErrMsgInfo> ClsErrMsgInfo { get; set; }
    }

    public class BranchDailyClsErrMsgInfo {
        public string ClsErrMsg { get; set; }
    }

    public class BranchDailyClsPayloadValidator : AbstractValidator<BranchDailyClsPayload> {
        public BranchDailyClsPayloadValidator() {
            RuleFor(x => x.ClsFlg).NotEmpty();
        }
    }
    
    public class BranchDailyClsRs : EsbT24CommonRs {
        public EsbHeaderInfo HeaderInfo { get; set; }
        public BranchDailyClsBranchClsInfo BranchClsInfo { get; set; }
    }

    public class BranchDailyClsBranchClsInfo {
        public string ClsFlg { get; set; }
        public string BussDate { get; set; }
        public string BranchStat { get; set; }
        public IEnumerable<BranchDailyClsErrMsgInfo> ClsErrMsgInfo { get; set; }
        public IEnumerable<BranchDailyClsOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<BranchDailyClsUpdtDateRec> UpdtDateRec { get; set; }
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

    public class BranchDailyClsOvrrdRec {
        public string Ovrrd { get; set; }
    }

    public class BranchDailyClsUpdtDateRec {
        public string UpdtDate { get; set; }
    }
}
