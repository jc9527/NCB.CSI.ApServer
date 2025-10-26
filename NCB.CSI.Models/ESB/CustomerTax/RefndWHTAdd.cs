using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.CustomerTax {
    [Validator(typeof(RefndWHTAddRqValidator))]
    public class RefndWHTAddRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public RefndWHTAddRqPayload Payload { get; set; }
    }

    public class RefndWHTAddRqValidator : AbstractValidator<RefndWHTAddRq> {
        public RefndWHTAddRqValidator() {
            RuleFor(x => x.Payload).NotNull();
        }
    }

    public class RefndWHTAddRqPayload {
        public IEnumerable<RefndWHTAddRqPayloadAcctNoRec> AcctNoRec { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadIntrstDateInfo> IntrstDateInfo { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadRefundTaxAmtInfo> RefundTaxAmtInfo { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadRecSeqNoInfo> RecSeqNoInfo { get; set; }
        public string DbCcy { get; set; }
        public string DbAcctNo { get; set; }
        public string CrCcy { get; set; }
        public string CrAmt { get; set; }
        public string CrAcctNo { get; set; }
        public string ComssnCode { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadComssnInfo> ComssnInfo { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadDbInfo> DbInfo { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadCrInfo> CrInfo { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadDbMemoInfo> DbMemoInfo { get; set; }
        public IEnumerable<RefndWHTAddRqPayloadCrMemoInfo> CrMemoInfo { get; set; }
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

    public class RefndWHTAddRqPayloadAcctNoRec {
        public string AcctNo { get; set; }
    }

    public class RefndWHTAddRqPayloadIntrstDateInfo {
        public string IntrstDate { get; set; }
    }

    public class RefndWHTAddRqPayloadRefundTaxAmtInfo {
        public string RefundTaxAmt { get; set; }
    }

    public class RefndWHTAddRqPayloadRecSeqNoInfo {
        public string RecSeqNo { get; set; }
    }

    public class RefndWHTAddRqPayloadComssnInfo {
        public string ComssnType { get; set; }
        public string ComssnAmt { get; set; }
    }

    public class RefndWHTAddRqPayloadDbInfo {
        public string DbRefData { get; set; }
    }

    public class RefndWHTAddRqPayloadCrInfo {
        public string CrRefData { get; set; }
    }

    public class RefndWHTAddRqPayloadDbMemoInfo {
        public string DbRefData { get; set; }
        public string DbRefDataConvt { get; set; }
    }

    public class RefndWHTAddRqPayloadCrMemoInfo {
        public string CrRefData { get; set; }
        public string CrRefDataConvt { get; set; }
    }

    public class RefndWHTAddRs : EsbT24CommonRs {
        public RefndWHTAddRsPayload Payload { get; set; }
    }


    public class RefndWHTAddRsPayload : RefndWHTAddRqPayload {
        public IEnumerable<RefndWHTAddRsPayloadOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<RefndWHTAddRsPayloadTxnDateRec> TxnDateRec { get; set; }
        public string Chan { get; set; }
    }

    public class RefndWHTAddRsPayloadOvrrdRec {
        public string Ovrrd { get; set; }
    }

    public class RefndWHTAddRsPayloadTxnDateRec {
        public string TxntDate { get; set; }
    }
}
