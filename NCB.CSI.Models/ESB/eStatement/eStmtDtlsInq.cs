using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.eStatement {
    [Validator(typeof(eStmtDtlsInqRqValidator))]
    public class eStmtDtlsInqRq : EsbDebitCardInqCommonRq {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string InqMnth { get; set; }
    }
    public class eStmtDtlsInqRqValidator : AbstractValidator<eStmtDtlsInqRq> {
        public eStmtDtlsInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid);
            RuleFor(x => x.InqMnth).NotEmpty().Matches(RegExConst.YYYYMM);
        }
    }
    public class eStmtDtlsInqRs : EsbNonT24CommonRs {
        public eStmtDtlsInqStmtRec StmtRec { get; set; }
    }
    public class eStmtDtlsInqStmtRec {
        public string CustPermId { get; set; }
        public string CustName { get; set; }
        public string eMail { get; set; }
        public string MobNo { get; set; }
        public string DlvrMthd { get; set; }
        public string BillYear { get; set; }
        public string BillMnth { get; set; }
        public IEnumerable<eStmtDtlsInqAcctBalInfo> AcctBalInfo { get; set; }
        public IEnumerable<eStmtDtlsInqTxnDtlsInfo> TxnDtlsInfo { get; set; }
        public IEnumerable<eStmtDtlsInqDbCardTxnDtlsInfo> DbCardTxnDtlsInfo { get; set; }
        public IEnumerable<eStmtDtlsInqRwdPntsInfo> RwdPntsInfo { get; set; }
    }
    public class eStmtDtlsInqAcctBalInfo {
        public string AcctType { get; set; }
        public string ProdName { get; set; }
        public string AcctNo { get; set; }
        public string AcctSeqNo { get; set; }
        public string CustName { get; set; }
        public string AcctOpnDate { get; set; }
        public string AcctClsDate { get; set; }
        public string AcctCcy { get; set; }
        public string AcctBal { get; set; }
        public string AcctBalTWD { get; set; }
        public string IntrstRate { get; set; }
        public string IntrstPmtType { get; set; }
        public string RenewPrd { get; set; }
        public string PktAcctStat { get; set; }
    }
    public class eStmtDtlsInqTxnDtlsInfo {
        public string AcctType { get; set; }
        public string AcctNo { get; set; }
        public string AcctSeqNo { get; set; }
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string AcctBal { get; set; }
        public string TxnAmt { get; set; }
        public string TxnDesc { get; set; }
        public string Memo { get; set; }
        public string TxnCcy { get; set; }
        public string Term { get; set; }
        public string PrncpleDecrAmt { get; set; }
        public string IntrstAmt { get; set; }
        public string OvdFee { get; set; }
    }
    public class eStmtDtlsInqDbCardTxnDtlsInfo {
        public string TxnType { get; set; }
        public string TxnDate { get; set; }
        public string PostDate { get; set; }
        public string TxnCtt { get; set; }
        public string TcxAmt { get; set; }
        public string CntryCode { get; set; }
        public string AmtCcy { get; set; }
        public string FCYAmt { get; set; }
        public string XchagDate { get; set; }
    }
    public class eStmtDtlsInqRwdPntsInfo {
        public string RwdPnts { get; set; }
        public string AddRwdPnts { get; set; }
        public string UsedRwdPnts { get; set; }
        public string BalRwdPnts { get; set; }

    }
}
