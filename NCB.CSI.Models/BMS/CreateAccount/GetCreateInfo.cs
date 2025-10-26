using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;

namespace NCB.CSI.Models.BMS.CreateAccount {
    [Validator(typeof(GetCreateInfoRqValidator))]
    public class GetCreateInfoRq {
        [LogItem("CustId")]
        public string idno { get; set; }
        public string phone { get; set; }
        public string seqNo { get; set; }
    }

    public class GetCreateInfoRqValidator : AbstractValidator<GetCreateInfoRq> {
        public GetCreateInfoRqValidator() {
            RuleFor(x => x.idno).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.phone) && string.IsNullOrWhiteSpace(x.seqNo));
            RuleFor(x => x.seqNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.idno) && string.IsNullOrWhiteSpace(x.phone));
            RuleFor(x => x.phone).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.idno) && string.IsNullOrWhiteSpace(x.seqNo));
        }
    }

    public class GetCreateInfoRs : BmsCommonRs<IEnumerable<GetCreateInfoData>> {
    }

    public class GetCreateInfoData {
        public string seqNo { get; set; }
        public string phoneNumber { get; set; }
        public string idno { get; set; }
        public string name { get; set; }
        public string mgmCode { get; set; }
        public string status { get; set; }
        public string rejectMemo { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string createTime { get; set; }
        public string updateTime { get; set; }
        public bool? isFirstUse { get; set; }
        public bool? isArchived { get; set; }
        public string lastStepDateTime { get; set; }
        public string memberProfileSeqNo { get; set; }
        public Stepbreakpoint stepBreakPoint { get; set; }
        public IEnumerable<Createdetail> createDetails { get; set; }
        public IEnumerable<BmsDocumentResend> documentResends { get; set; }
        public ManualReviewFlag manualReviewFlag { get; set; }
        public IEnumerable<TellerCheckRecord> tellerCheckRecords { get; set; }
        public IEnumerable<string> abnormalPid { get; set; }
    }

    public class Createdetail {
        public string seqNo { get; set; }
        public string createMasterSeqNo { get; set; }
        public string imei { get; set; }
        public string ipv4 { get; set; }
        public string ipv6 { get; set; }
        public string gps { get; set; }
        public string deviceRecord { get; set; }
        public string termGeneralAgrmt { get; set; }
        public string termMemberService { get; set; }
        public string termPointMarketingAgrmt { get; set; }
        public string termCommonMarketingAgrmt { get; set; }
        public string termPersonalAgrmt { get; set; }
        public bool? isAgreed3thPartyUsed { get; set; }
        public DateTime? agreedDate { get; set; }
        public string applyPurpose { get; set; }
        public BmsCodeAndName industry { get; set; }
        public BmsCodeAndName job { get; set; }
        public string organization { get; set; }
        public bool? isSalaryAccount { get; set; }
        public string acverinputBank { get; set; }
        public string acverinputAccNo { get; set; }
        public DateTime? acverinputDate { get; set; }
        public bool? isFatca { get; set; }
        public bool? isPayTaxes { get; set; }
        public bool? isTwTaxPayer { get; set; }
        public string idno { get; set; }
        public string name { get; set; }
        public string aboriginalName { get; set; }
        public string gender { get; set; }
        public string spouse { get; set; }
        public string birthYear { get; set; }
        public string birthMonth { get; set; }
        public string birthDate { get; set; }
        public string idIssueYear { get; set; }
        public string idIssueMonth { get; set; }
        public string idIssueDate { get; set; }
        public BmsCodeAndName idIssueCity { get; set; }
        public BmsCodeAndName idIssueWay { get; set; }
        public string residentCity { get; set; }
        public string residentDistrict { get; set; }
        public string residentAddress { get; set; }
        public string residentPostalCode { get; set; }
        public string firstFront { get; set; }
        public string firstBack { get; set; }
        public string ocrSecFrontImageID { get; set; }
        public bool? isModified { get; set; }
        public string videoViewFileName { get; set; }
        public string videoSoundFileName { get; set; }
        public string cardFace { get; set; }
        public string cardName { get; set; }
        public string cardEmail { get; set; }
        public string cardCity { get; set; }
        public string cardArea { get; set; }
        public string cardAddress { get; set; }
        public string cardAddressCode { get; set; }
        public string userID { get; set; }
        public string psd { get; set; }
        public string createAccountStatus { get; set; }
    }

    public class Stepbreakpoint {
        public string seqNo { get; set; }
        public string step01State { get; set; }
        public string step01UpdateDate { get; set; }
        public string step01UpdateTime { get; set; }
        public string step02State { get; set; }
        public string step02UpdateDate { get; set; }
        public string step02UpdateTime { get; set; }
        public string step03State { get; set; }
        public string step03UpdateDate { get; set; }
        public string step03UpdateTime { get; set; }
        public string step04State { get; set; }
        public string step04UpdateDate { get; set; }
        public string step04UpdateTime { get; set; }
        public string step05State { get; set; }
        public string step05UpdateDate { get; set; }
        public string step05UpdateTime { get; set; }
        public string step06State { get; set; }
        public string step06UpdateDate { get; set; }
        public string step06UpdateTime { get; set; }
        public string step07State { get; set; }
        public string step07UpdateDate { get; set; }
        public string step07UpdateTime { get; set; }
        public string step08State { get; set; }
        public string step08UpdateDate { get; set; }
        public string step08UpdateTime { get; set; }
        public string step09State { get; set; }
        public string step09UpdateDate { get; set; }
        public string step09UpdateTime { get; set; }
        public string step10State { get; set; }
        public string step10UpdateDate { get; set; }
        public string step10UpdateTime { get; set; }
        public string step11State { get; set; }
        public string step11UpdateDate { get; set; }
        public string step11UpdateTime { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string createTime { get; set; }
        public string updateTime { get; set; }
    }

    public class ManualReviewFlag : BmsManualReviewFlag {
        public OcrFlagDetail ocrFlagDetail { get; set; }
        public Z21FlagDetail z21FlagDetail { get; set; }
        public Z22FlagDetail z22FlagDetail { get; set; }
        public AmlFlagDetail amlFlagDetail { get; set; }
        public IEnumerable<PayTaxes> payTaxes { get; set; }
    }

    public class AmlFlagDetail {
        public int seqNo { get; set; }
        public bool? isInSanctionList { get; set; }
        public bool? isInPepsList { get; set; }
        public string riskLevel { get; set; }
    }

    public class OcrFlagDetail {
        public string createTime { get; set; }
        public string updateTime { get; set; }
        public int seqNo { get; set; }
        public string birthYear { get; set; }
        public string birthMonth { get; set; }
        public string birthDate { get; set; }
        public string idIssueYear { get; set; }
        public string idIssueMonth { get; set; }
        public string idIssueDate { get; set; }
        public string idIssueCity { get; set; }
        public BmsCodeAndName idIssueWay { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string address { get; set; }
        public string postalCode { get; set; }
        public string firstBack { get; set; }
        public string firstFront { get; set; }
        public string name { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string aboriginalName { get; set; }
        public string createMasterSeqNo { get; set; }
        public string spouse { get; set; }
        public string birthPlace { get; set; }
        public string military { get; set; }
        public string naturalFather { get; set; }
        public string naturalMother { get; set; }
        public string secondFront { get; set; }
        public string gender { get; set; }
        public string barCode { get; set; }
        public string serialNo { get; set; }
    }

    public class Z21FlagDetail {
        public int seqNo { get; set; }
        public string z21ResultCode { get; set; }
        public string z21ResultMessage { get; set; }
        public string z21NewBussCount { get; set; }
    }

    public class Z22FlagDetail {
        public int seqNo { get; set; }
        public string z22ActType { get; set; }
        public string z22MsgNewSubCode { get; set; }
    }

    public class PayTaxes {
        public string IDNO { get; set; }
        public BmsCodeAndName countryCode { get; set; }
        public string createdDate { get; set; }
        public string createdTime { get; set; }
        public int seqNo { get; set; }
        public string taxesNo { get; set; }
        public string updateDate { get; set; }
        public string updateTime { get; set; }
    }

    public class TellerCheckRecord {
        public int seqNo { get; set; }
        public string createMasterSeqNo { get; set; }
        public string tellerNo { get; set; }
        public string tellerCheckDate { get; set; }
        public string tellerCheckTime { get; set; }
        public string tellerMemo { get; set; }
        public string managerNo { get; set; }
        public string managerCheckDate { get; set; }
        public string managerCheckTime { get; set; }
        public string managerMemo { get; set; }
        public string checkStatus { get; set; }
        public string createDateTime { get; set; }
        public string updateDateTime { get; set; }
    }
}
