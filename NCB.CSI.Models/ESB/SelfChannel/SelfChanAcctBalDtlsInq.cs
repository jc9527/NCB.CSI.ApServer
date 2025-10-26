using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.SelfChannel {
    [Validator(typeof(SelfChanAcctBalDtlsInqRqValidator))]
    public class SelfChanAcctBalDtlsInqRq : EsbRqServiceBody {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
    }

    public class SelfChanAcctBalDtlsInqRqValidator : AbstractValidator<SelfChanAcctBalDtlsInqRq> {
        public SelfChanAcctBalDtlsInqRqValidator() {
            RuleFor(x => x.AcctNo).NotEmpty();
        }
    }

    public class SelfChanAcctBalDtlsInqRs: EsbNonT24CommonRs {
        public SelfChanAcctBalDtlsInqSelfChanAvailBalRec SelfChanAvailBalRec { get; set; }
    }

    public class SelfChanAcctBalDtlsInqSelfChanAvailBalRec {
        public SelfChanAcctBalDtlsInqATMWdlBalInfo ATMWdlBalInfo { get; set; }
        public SelfChanAcctBalDtlsInqATMWdrwlCardlssBalInfo ATMWdrwlCardlssBalInfo { get; set; }
        public SelfChanAcctBalDtlsInqATMPDBalInfo ATMPDBalInfo { get; set; }
        public SelfChanAcctBalDtlsInqeBillAvailBalInfo eBillAvailBalInfo { get; set; }
        public SelfChanAcctBalDtlsInqDgtlAcctType3NPDAvailBalInfo DgtlAcctType3NPDAvailBalInfo { get; set; }
    }

    public class SelfChanAcctBalDtlsInqATMWdlBalInfo {
        public string ATMWdlAmt { get; set; }
        public string ATMWdlLmt { get; set; }
        public string ATMWdlDayLmt { get; set; }
        public string AmtCcy { get; set; }
    }

    public class SelfChanAcctBalDtlsInqATMWdrwlCardlssBalInfo {
        public string ATMWdrwlCardlssLmt { get; set; }
        public string ATMWdrwlCardlssAmt { get; set; }
        public string ATMWdrwlCardlssDayLmt { get; set; }
    }

    public class SelfChanAcctBalDtlsInqATMPDBalInfo {
        public string ATMPDLmt { get; set; }
        public string ATMPDAmt { get; set; }
        public string ATMPDDayLmt { get; set; }
        public string AmtCcy { get; set; }
    }

    public class SelfChanAcctBalDtlsInqeBillAvailBalInfo {
        public string eBillMinAcctLmt { get; set; }
        public string eBillMinAcctLmtUsed { get; set; }
        public string eBillMinAcctDayLmt { get; set; }
        public string eBillMinAcctMnthLmt { get; set; }
        public string eBillMinAcctMnthUsed { get; set; }
        public string eBillMinAcctMnthAvail { get; set; }
        public string eBillMaxAcctLmt { get; set; }
        public string eBillMaxAcctLmtUsed { get; set; }
        public string eBillMaxAcctDayLmt { get; set; }
        public string eBillBankCardLmt { get; set; }
        public string eBillBankCardUsed { get; set; }
        public string eBillBankCardDayLmt { get; set; }
        public string AmtCcy { get; set; }
    }

    public class SelfChanAcctBalDtlsInqDgtlAcctType3NPDAvailBalInfo {
        public string DgtlAcctType3NPDLmt { get; set; }
        public string DgtlAcctType3NPDAmt { get; set; }
        public string DgtlAcctType3NPDDayLmt { get; set; }
        public string DgtlAcctType3NPDMnthLmt { get; set; }
        public string DgtlAcctType3NPDMnthAmt { get; set; }
        public string DgtlAcctType3NPDMnthAvail { get; set; }
        public string AmtCcy { get; set; }
    }
}
