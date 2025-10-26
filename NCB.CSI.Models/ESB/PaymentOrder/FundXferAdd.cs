using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.PaymentOrder {
    [Validator(typeof(FundXferAddRqValidator))]
    public class FundXferAddRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public FundXferAddPayload Payload { get; set; }
    }

    public class FundXferAddPayload {
        public string TxnType { get; set; }
        public string DbAcctNo { get; set; }
        public string DbCcy { get; set; }
        public decimal? Dbamt { get; set; }
        public string CrAcctNo { get; set; }
        public string CrCcy { get; set; }
        public decimal? CrAmt { get; set; }
        public string FeeAcctNo { get; set; }
        public string ComssnCode { get; set; }
        public IEnumerable<FundXferAddComssnInfo> ComssnInfo { get; set; }
        public IEnumerable<FundXferAddDbInfo> DbInfo { get; set; }
        public IEnumerable<FundXferAddCrInfo> CrInfo { get; set; }
        public IEnumerable<FundXferAddDbMemoInfo> DbMemoInfo { get; set; }
        public IEnumerable<FundXferAddCrMemoInfo> CrMemoInfo { get; set; }
        public string PmtType { get; set; }
        public string PmtDate { get; set; }
        public string TxnNo { get; set; }
        public decimal? AcctBal { get; set; }
        public decimal? AvailBal { get; set; }
        public IEnumerable<FundXferAddPmtVldtInfo> PmtVldtInfo { get; set; }
        public decimal? OrigTxnAmt { get; set; }
        public IEnumerable<FundXferAddOrigFeeInfo> OrigFeeInfo { get; set; }
        public string ChanTxnNo { get; set; }
        public string SameIdFlg { get; set; }
        public string DgtlAcctType { get; set; }
        public IEnumerable<FundXferAddStmtNoInfo> StmtNoInfo { get; set; }
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
    }

    public class FundXferAddComssnInfo {
        public string ComssnType { get; set; }
        public decimal? ComssnAmt { get; set; }
        public string ComssnFor { get; set; }

    }

    public class FundXferAddDbInfo {
        public string DbRefData { get; set; }
    }

    public class FundXferAddCrInfo {
        public string CrRefData { get; set; }
    }

    public class FundXferAddDbMemoInfo {
        public string DbRefData { get; set; }
        public string DbRefDataConvt { get; set; }
    }

    public class FundXferAddCrMemoInfo {
        public string CrRefData { get; set; }
        public string CrRefDataConvt { get; set; }
    }

    public class FundXferAddPmtVldtInfo {
        public string PmtVldtRule { get; set; }
        public string PmtVldtData { get; set; }
    }

    public class FundXferAddOrigFeeInfo {
        public string OrigFeeType { get; set; }
        public decimal? OrigFeeAmt { get; set; }
        public decimal? HdlgChrg { get; set; }
        public string FeeWvdKey { get; set; }
    }

    public class FundXferAddStmtNoInfo {
        public string StmtNo { get; set; }
    }
 
    public class FundXferAddRqValidator : AbstractValidator<FundXferAddRq> {
        public FundXferAddRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
        }
    }

    public class FundXferAddRs : EsbT24CommonRs {
        public FundXferAddRsInfo FundXferAddInfo { get; set; }
    }

    public class FundXferAddRsInfo : FundXferAddPayload {
        public string Chan { get; set; }
    }
}