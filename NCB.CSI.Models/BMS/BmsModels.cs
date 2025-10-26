using Devpro.Shared.Misc.Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS {
    public class BmsCommonRs {
        public bool success { get; set; }
        public BmsError error { get; set; }
    }

    public class BmsCommonRs<T> : BmsCommonRs {
        public T data { get; set; }
    }

    public class BmsError {
        public string errorCode { get; set; }
        public string errorMessage { get; set; }
    }

    public class BmsCodeAndName {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class BmsCodeAndValue {
        public string code { get; set; }
        public string value { get; set; }
    }

    public class BmsDocumentResend {
        public string seqNo { get; set; }
        public string createMasterSeqNo { get; set; }
        public string caseNmber { get; set; }
        public string resendProdType { get; set; }
        public string resendReason { get; set; }
        public string createDateTime { get; set; }
        public string updateDateTime { get; set; }
        public string category { get; set; }
        [JsonConverter(typeof(SingleToArrayConverter<string>))]
        public IEnumerable<string> resendContent { get; set; }
        public string resendStatus { get; set; }
        public string resendRejectReason { get; set; }
        public string creator { get; set; }
    }

    public class BmsManualReviewFlag {
        public int? seqNo { get; set; }
        public string createMasterSeqNo { get; set; }
        public bool? p2566 { get; set; }
        public int? ocr { get; set; }
        public bool? ocrScanError { get; set; }
        public int? z22 { get; set; }
        public int? aml { get; set; }
        public bool? sameIpDiffEmail { get; set; }
        public bool? bornInUSA { get; set; }
        public bool? rarelyWord { get; set; }
        public bool? firstFrontScanError { get; set; }
        public bool? firstBackScanError { get; set; }
        public bool? secondScanError { get; set; }
        public bool? sameIpWithDiffPid { get; set; }
        public DateTime? sameIpWithDiffPidDatetime { get; set; }
        public string z21ExceedTimes { get; set; }
        public IEnumerable<string> special { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
    }
}
