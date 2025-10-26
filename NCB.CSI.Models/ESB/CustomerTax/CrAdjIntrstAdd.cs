using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.CustomerTax {
    [Validator(typeof(CrAdjIntrstAddRqValidator))]
    public class CrAdjIntrstAddRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadAcctNoRec> AcctNoRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadPmtDateRec> PmtDateRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadPmtAmtRec> PmtAmtRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadInstrstTypeRec> InstrstTypeRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadSeqNoRec> SeqNoRec { get; set; }
        public string CrAcctNo { get; set; }
        public string CrCcy { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadDbRefDataRec> DbRefDataRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadCrRefDataRec> CrRefDataRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadDbMemoInfo> DbMemoInfo { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadCrMemoInfo> CrMemoInfo { get; set; }
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

    public class CrAdjIntrstAddRqValidator : AbstractValidator<CrAdjIntrstAddRq> {
        public CrAdjIntrstAddRqValidator() {
        }
    }

    public class CrAdjIntrstAddRqPayloadAcctNoRec {
        public string AcctNo { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadPmtDateRec {
        public string PmtDate { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadPmtAmtRec {
        public string PmtAmt { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadInstrstTypeRec {
        public string InstrstType { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadSeqNoRec {
        public string SeqNo { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadDbRefDataRec {
        public string DbRefData { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadCrRefDataRec {
        public string CrRefData { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadDbMemoInfo {
        public string DbMemo { get; set; }
        public string DbRefDataConvt { get; set; }
    }

    public class CrAdjIntrstAddRqPayloadCrMemoInfo {
        public string CrMemo { get; set; }
        public string CrRefDataConvt { get; set; }
    }

    public class CrAdjIntrstAddRs : EsbT24CommonRs {
        public CrAdjIntrstAddRsPayload RsrvdAcctNoInfo { get; set; }
    }

    public class CrAdjIntrstAddRsPayload {
        public IEnumerable<CrAdjIntrstAddRqPayloadAcctNoRec> AcctNoRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadPmtDateRec> PmtDateRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadPmtAmtRec> PmtAmtRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadInstrstTypeRec> InstrstTypeRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadSeqNoRec> SeqNoRec { get; set; }
        public string DbAcctNo { get; set; }
        public string DbCcy { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadDbRefDataRec> DbRefDataRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadCrRefDataRec> CrRefDataRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadDbMemoInfo> DbMemoInfo { get; set; }
        public IEnumerable<CrAdjIntrstAddRqPayloadCrMemoInfo> CrMemoInfo { get; set; }
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
        public IEnumerable<CrAdjIntrstAddRsPayloadOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<CrAdjIntrstAddRsPayloadTxnDateRec> TxnDateRec { get; set; }
        public string Chan { get; set; }
    }

    public class CrAdjIntrstAddRsPayloadOvrrdRec {
        public string Ovrrd { get; set; }
    }

    public class CrAdjIntrstAddRsPayloadTxnDateRec {
        public string TxntDate { get; set; }
    }
}
