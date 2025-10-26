using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devpro.Shared.Misc.Newtonsoft;
using Newtonsoft.Json;

namespace NCB.CSI.Models.ESB {
    public class EsbPageInfoRq {
        public int PageSize { get; set; }
        public int PageStart { get; set; }
    }

    public class EsbPageInfoRs : EsbPageInfoRq {
        public int NoOfRec { get; set; }
        public string PageToken { get; set; }
    }

    public class EsbRtrnStatCode {
        public string RtrnCode { get; set; }
        public string RtrnDesc { get; set; }
    }

    public class EsbAudit {
        public string T24Time { get; set; }
        public string VerNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }

    public class EsbRqServiceBody {
    }

    public class EsbInqCommonRq : EsbRqServiceBody {
        public EsbPageInfoRq PageInfo { get; set; }
    }

    public class EsbDebitCardCommonRq : EsbRqServiceBody {
        public string UserName { get; set; }
    }

    public class EsbDebitCardInqCommonRq : EsbDebitCardCommonRq {
        public int InqPageNo { get; set; } = 1;
        public int NoOfPage { get; set; } = 200;
    }

    public class EsbBankCardInqCommonRq : EsbRqServiceBody { 
        public int PageNo { get; set; } = 1;
        public int NoOfPage { get; set; } = 200;
    }

    public interface IEsbCommonRs {
        EsbRtrnStatCode RtrnStatCode { get; set; }
        EsbFault Fault { get; set; }
        bool Success { get; }
    }

    public class EsbFault {
        public EsbFaultCode Code { get; set; }
        public EsbFaultReason Reason { get; set; }
        public EsbFaultDetail Detail { get; set; }
    }

    public class EsbFaultCode {
        public string Value { get; set; }
    }

    public class EsbFaultReason {
        public string Text { get; set; }
    }

    public class EsbFaultDetail {
        public EsbFaultDetailFault Fault { get; set; }
    }

    public class EsbFaultDetailFault {
        public string ErrorCode { get; set; }
        public string ErrorString { get; set; }
    }

    public class EsbT24CommonRs : IEsbCommonRs {
        [JsonConverter(typeof(ArrayToSingleConverter<EsbRtrnStatCode>))]
        public EsbRtrnStatCode RtrnStatCode { get; set; }
        public EsbFault Fault { get; set; }
        public bool Success => Fault == null && new[] { "200", "404", "E000" }.Contains(RtrnStatCode.RtrnCode);
    }

    public class EsbT24InqCommonRs : EsbT24CommonRs {
        public EsbPageInfoRs PageInfo { get; set; }
        public EsbAudit Audit { get; set; }
    }

    [JsonConverter(typeof(JsonPathConverter))]
    public class EsbNonT24CommonRs : IEsbCommonRs {
        [JsonPath("")]
        public EsbRtrnStatCode RtrnStatCode { get; set; }
        public EsbFault Fault { get; set; }
        public bool Success => Fault == null && RtrnStatCode.RtrnCode == "00";
    }

    public class EsbNonT24InqCommonRs : EsbNonT24CommonRs {
        public EsbControlRec ControlRec { get; set; }
    }

    public class EsbCntctInfo {
        public string ResPhnNo { get; set; }
        public string MobNo { get; set; }
        public string eMailAddr { get; set; }
    }

    public class EsbAddr {
        public string AddrZip { get; set; }
        public string St { get; set; }
        public string Addr { get; set; }
        public string TownCnty { get; set; }
        public string Cntry { get; set; }
    }

    public class EsbEngAddr {
        public string EngAddr { get; set; }
    }

    [JsonConverter(typeof(JsonPathConverter))]
    public class EsbPostRstrctRsnRec {
        [JsonPath("['PostRsn','PostRstrctRsn']")]
        public string PostRsn { get; set; }
    }

    public class EsbPostRstrctRec {
        public string PostRstrctCode { get; set; }
        public string PostRstrctRsn { get; set; }
    }

    public class EsbEcoRec {
        public string EcoType { get; set; }
        public string EcoId { get; set; }
        public string EcoDate { get; set; }
        public string EcoNextId { get; set; }
    }

    public class EsbControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }

    public class EsbHeaderInfo {
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public EsbAudit Audit { get; set; }
    }
}
