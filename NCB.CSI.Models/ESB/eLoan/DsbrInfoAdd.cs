using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eLoan {
    [Validator(typeof(DsbrInfoAddRqValidator))]
    public class DsbrInfoAddRq : EsbRqServiceBody {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string AppRefNo { get; set; }
        public string AppNo { get; set; }
        public string RmtBankType { get; set; }
        public string BankCode { get; set; }
        public string DsbrAcct { get; set; }
        public string LnkAcct { get; set; }
        [LogItem("AccountNo")]
        public string DbAcct { get; set; }
        public string RepmtCycl { get; set; }
    }
    public class DsbrInfoAddRqValidator : AbstractValidator<DsbrInfoAddRq> {
        public DsbrInfoAddRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.AppRefNo).NotEmpty();
            RuleFor(x => x.AppNo).NotEmpty();
            RuleFor(x => x.RmtBankType).NotEmpty();
            RuleFor(x => x.BankCode).NotEmpty();
        }
    }
    public class DsbrInfoAddRs : EsbNonT24CommonRs {
        public DsbrInfoAddDsbrInfoAddRec DsbrInfoAddRec { get; set; }
    }
    public class DsbrInfoAddDsbrInfoAddRec {
        public string CustPermId { get; set; }
        public string AppRefNo { get; set; }
        public string AppNo { get; set; }
    }
}
