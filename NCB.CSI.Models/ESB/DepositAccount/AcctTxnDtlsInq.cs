using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.DepositAccount {
    [Validator(typeof(AcctTxnDtlsInqRqValidator))]
    public class AcctTxnDtlsInqRq : EsbInqCommonRq {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public string TxnDateType { get; set; }
        public string TxnStartDate { get; set; }
        public string TxnEndDate { get; set; }
        public string NoOfRec { get; set; }
        public string TxnSeqNo { get; set; }
    }

    public class AcctTxnDtlsInqRqValidator : AbstractValidator<AcctTxnDtlsInqRq> {
        public AcctTxnDtlsInqRqValidator() {
            RuleFor(x => x.AcctNo).NotEmpty();
            RuleFor(x => x.TxnDateType).NotEmpty();
            RuleFor(x => x.TxnStartDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.TxnEndDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class AcctTxnDtlsInqRs : EsbT24InqCommonRs {
        public IEnumerable<AcctTxnDtlsInqAcctBalInfo> AcctBalInfo { get; set; }
    }

    public class AcctTxnDtlsInqAcctBalInfo {
        public string CustPermId { get; set; }
        public string CustPrntName { get; set; }
        public string AcctNo { get; set; }
        public IEnumerable<AcctTxnDtlsInqAcctTxnRec> AcctTxnRec { get; set; }
    }

    public class AcctTxnDtlsInqAcctTxnRec {
        public string DataType { get; set; }
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string PostDate { get; set; }
        public string InitIntrstDate { get; set; }
        public string AcctCcy { get; set; }
        public string TxnDesc { get; set; }
        public string Memo { get; set; }
        public string RvslCode { get; set; }
        public string TxnAmt { get; set; }
        public string AcctBal { get; set; }
        public string CurRate { get; set; }
        public string ForExRate { get; set; }
        public string DbAcctNo { get; set; }
        public string CrAcctNo { get; set; }
        public string ConsumerTxnNo { get; set; }
        public string TxnType { get; set; }
        public string TxnTypeDesc { get; set; }
        public string FISCTxnNo { get; set; }
        public string BankCode { get; set; }
        public string TxnAcctNo { get; set; }
        public string TxnRefData { get; set; }
        public string AcctTitl { get; set; }
        public string VerName { get; set; }
        public string Chan { get; set; }
        public string EntryEmplNo { get; set; }
        public string AuthEmpId { get; set; }
        public string EntryDeptCode { get; set; }
        public string PktAcctNo { get; set; }
        public string TxnRefNo { get; set; }
    }
}
