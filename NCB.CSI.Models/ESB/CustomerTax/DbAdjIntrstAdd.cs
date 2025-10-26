using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.CustomerTax {
    [Validator(typeof(DbAdjIntrstAddRqValidator))]
    public class DbAdjIntrstAddRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadAcctNoRec> AcctNoRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadPmtDateRec> PmtDateRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadPmtAmtRec> PmtAmtRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadInstrstTypeRec> InstrstTypeRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadSeqNoRec> SeqNoRec { get; set; }
        public string DbAcctNo { get; set; }
        public string DbCcy { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadDbRefDataRec> DbRefDataRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadCrRefDataRec> CrRefDataRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadDbMemoInfo> DbMemoInfo { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadCrMemoInfo> CrMemoInfo { get; set; }
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

    public class DbAdjIntrstAddRqValidator : AbstractValidator<DbAdjIntrstAddRq> {
        public DbAdjIntrstAddRqValidator() {
        }
    }

    public class DbAdjIntrstAddRqPayloadAcctNoRec {
        public string AcctNo { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadPmtDateRec {
        public string PmtDate { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadPmtAmtRec {
        public string PmtAmt { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadInstrstTypeRec {
        public string InstrstType { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadSeqNoRec {
        public string SeqNo { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadDbRefDataRec {
        public string DbRefData { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadCrRefDataRec {
        public string CrRefData { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadDbMemoInfo {
        public string DbMemo { get; set; }
        public string DbRefDataConvt { get; set; }
    }

    public class DbAdjIntrstAddRqPayloadCrMemoInfo {
        public string CrMemo { get; set; }
        public string CrRefDataConvt { get; set; }
    }

    public class DbAdjIntrstAddRs : EsbT24CommonRs {
        public DbAdjIntrstAddRsPayload RsrvdAcctNoInfo { get; set; }
    }

    public class DbAdjIntrstAddRsPayload {
        public IEnumerable<DbAdjIntrstAddRqPayloadAcctNoRec> AcctNoRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadPmtDateRec> PmtDateRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadPmtAmtRec> PmtAmtRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadInstrstTypeRec> InstrstTypeRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadSeqNoRec> SeqNoRec { get; set; }
        public string DbAcctNo { get; set; }
        public string DbCcy { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadDbRefDataRec> DbRefDataRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadCrRefDataRec> CrRefDataRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadDbMemoInfo> DbMemoInfo { get; set; }
        public IEnumerable<DbAdjIntrstAddRqPayloadCrMemoInfo> CrMemoInfo { get; set; }
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
        public IEnumerable<DbAdjIntrstAddRsPayloadOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<DbAdjIntrstAddRsPayloadTxnDateRec> TxnDateRec { get; set; }
        public string Chan { get; set; }
    }

    public class DbAdjIntrstAddRsPayloadOvrrdRec {
        public string Ovrrd { get; set; }
    }

    public class DbAdjIntrstAddRsPayloadTxnDateRec {
        public string TxntDate { get; set; }
    }
}
