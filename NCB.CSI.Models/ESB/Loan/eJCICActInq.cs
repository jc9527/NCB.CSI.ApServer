using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Loan {
    [Validator(typeof(eJCICActInqRqValidator))]
    public class eJCICActInqRq : EsbRqServiceBody {
        public string BankId { get; set; }
        public string BrchId { get; set; }
        public string JCICTxnId { get; set; }
        public string InqSysType { get; set; }
        public string MsgId { get; set; }
        public string ChrgCode { get; set; }
        public string InqEmplId { get; set; }
        public string InqEmplName { get; set; }
        public string InqRsnCode { get; set; }
        public string InqDeptCode { get; set; }
        public string CustPermId { get; set; }
        public string IssDate { get; set; }
        public string IssType { get; set; }
        public string BirthDay { get; set; }
        public string PicFreeFlg { get; set; }
        public string IssLoc { get; set; }
        public string SendJCICFlg { get; set; }
    }

    public class eJCICActInqRqValidator : AbstractValidator<eJCICActInqRq> {
        public eJCICActInqRqValidator() {
            RuleFor(x => x.BankId).NotEmpty();
            RuleFor(x => x.BrchId).NotEmpty();
            RuleFor(x => x.JCICTxnId).NotEmpty();
            RuleFor(x => x.InqSysType).NotEmpty();
            RuleFor(x => x.MsgId).NotEmpty();
            RuleFor(x => x.ChrgCode).NotEmpty();
            RuleFor(x => x.InqEmplId).NotEmpty();
            RuleFor(x => x.InqEmplName).NotEmpty();
            RuleFor(x => x.InqRsnCode).NotEmpty();
            RuleFor(x => x.InqDeptCode).NotEmpty();
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.SendJCICFlg).NotEmpty();
        }
    }

    public class eJCICActInqRs : EsbNonT24CommonRs {
        public eJCICActInqRsJCICRsInfo JCICRsInfo { get; set; }
    }

    public class eJCICActInqRsJCICRsInfo {
        public string JCICTxnId { get; set; }
        public string MsgId { get; set; }
        public string nqKeyId1 { get; set; }
        public string InqKeyId2 { get; set; }
        public string SendJCICFlg { get; set; }
        public eJCICActInqRsJCICRsRawData RawData { get; set; }
    }

    public class eJCICActInqRsJCICRsRawData {
        public eJCICActInqRsJCICRsPIDInfo PIDInfo { get; set; }
        public eJCICActInqRsCustChnNameInfo CustChnNameInfo { get; set; }
        public eJCICActInqRsRsDate RsDate { get; set; }
        public eJCICActInqRsPIDRec PIDRec { get; set; }
        public eJCICActInqRsJCICActInfo JCICActInfo { get; set; }
        public eJCICActInqRsMsgInfo MsgInfo { get; set; }
        public eJCICActInqRsInqBankInfo InqBankInfo { get; set; }
        public eJCICActInqRsLast3MnthInqBankInfo Last3MnthInqBankInfo { get; set; }
        public eJCICActInqRsInqBussCnt InqBussCnt { get; set; }
    }

    public class eJCICActInqRsJCICRsPIDInfo {
        public string AtomId { get; set; }
        public string CustPermId { get; set; }
        public string CustChnName { get; set; }
        public string Filler { get; set; }
    }

    public class eJCICActInqRsCustChnNameInfo {
        public string AtomId { get; set; }
        public string CustChnFullName { get; set; }
    }

    public class eJCICActInqRsRsDate {
        public string AtomId { get; set; }
        public string RtrnDate { get; set; }
    }

    public class eJCICActInqRsPIDRec {
        public string AtomId { get; set; }
        public string CustPermId { get; set; }
        public string IssDate { get; set; }
        public string IssType { get; set; }
        public string BirthDay { get; set; }
        public string PicFreeFlg { get; set; }
        public string IssLoc { get; set; }
        public string VrfyRsltCode { get; set; }
        public string VrfyRsltDesc { get; set; }
    }

    public class eJCICActInqRsJCICActInfo {
        public string AtomId { get; set; }
        public IEnumerable<eJCICActInqRsJCICActRec> JCICActRec { get; set; }
    }

    public class eJCICActInqRsJCICActRec {
        public string ActType { get; set; }
        public string CriPlc { get; set; }
        public string CriDate { get; set; }
        public string ActDate { get; set; }
        public string CustChnName { get; set; }
        public string InvcNo { get; set; }
        public string Rmk1 { get; set; }
        public string Rmk2 { get; set; }
        public string Rmk3 { get; set; }
        public string Rmk4 { get; set; }
        public string ActOrgName { get; set; }
        public string RlsCode { get; set; }
        public string RlsRsn { get; set; }
        public string RlsDate { get; set; }
        public string Filler { get; set; }
    }

    public class eJCICActInqRsMsgInfo {
        public string AtomId { get; set; }
        public IEnumerable<eJCICActInqRsMsgRec> MsgRec { get; set; }
    }

    public class eJCICActInqRsMsgRec {
        public string CustPermId { get; set; }
        public string MsgDate { get; set; }
        public string MsgMainCode { get; set; }
        public string MsgMainNote { get; set; }
        public string MsgSubCode { get; set; }
        public string MsgSubNote { get; set; }
        public string MsgtCntt { get; set; }
        public string MsgNewSubCode { get; set; }
        public string Filler { get; set; }
    }

    public class eJCICActInqRsInqBankInfo {
        public string AtomId { get; set; }
        public IEnumerable<eJCICActInqRsInqBankInfo1> InqBankInfo1 { get; set; }
    }

    public class eJCICActInqRsInqBankInfo1 {
        public string InqBankId { get; set; }
        public string InqBankName { get; set; }
        public string InqPurp1 { get; set; }
        public string InqPurp { get; set; }
    }

    public class eJCICActInqRsLast3MnthInqBankInfo {
        public string AtomId { get; set; }
        public IEnumerable<eJCICActInqRsInqBankInfo2> InqBankInfo2 { get; set; }
    }

    public class eJCICActInqRsInqBankInfo2 {
        public string InqDate { get; set; }
        public string InqBankId { get; set; }
        public string InqBankName { get; set; }
        public string InqPurp1 { get; set; }
        public string InqPurp { get; set; }
    }

    public class eJCICActInqRsInqBussCnt {
        public string AtomId { get; set; }
        public string InqNewBussTime { get; set; }
        public string InqOldBussTime { get; set; }
        public string NewAcctOpnCnt { get; set; }
        public string OldAcctCnt { get; set; }
    }
}
