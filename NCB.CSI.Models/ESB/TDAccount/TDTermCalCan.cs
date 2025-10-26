using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDTermCalCanRqValidator))]
    public class TDTermCalCanRq : EsbRqServiceBody {
        [LogItem("AccountNo")]
        public string AcctNo { get; set; }
        public bool? ValidateOnly { get; set; }
        public TDTermCalCanPayload Payload { get; set; }
    }
    public class TDTermCalCanPayload {
        public string CustId { get; set; }
        public string ArrngId { get; set; }
        public string PreClsOpt { get; set; }
        public string Ccy { get; set; }
        public string Amt { get; set; }
        public string InitIntrstDate { get; set; }
        public string FltRateFlg { get; set; }
        public string IntrstRateKey { get; set; }
        public string WHTTaxRate { get; set; }
        public string NHIRate { get; set; }
        public string IntrstRate { get; set; }
        public string PaidIntrstAmt { get; set; }
        public string IntrstPayAmt { get; set; }
        public string IntrstPayRcvrAmt { get; set; }
        public string PreClsDate { get; set; }
        public string StlAcctNo { get; set; }
        public string WHTAmtLCY { get; set; }
        public string WHTAmtFCY { get; set; }
        public string NHIAmtLCY { get; set; }
        public string NHIAmtFCY { get; set; }
        public string WHTAcctNo { get; set; }
        public string NHIAcctNo { get; set; }
        public IEnumerable<TDTermCalCanFTIDRec> FTIDRec { get; set; }
        public string ExRate { get; set; }
        public string Rsn { get; set; }
        public IEnumerable<TDTermCalCanOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<TDTermCalCanTxnDateRec> TxnDateRec { get; set; }
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
        public string Chan { get; set; }
    }
    public class TDTermCalCanRqValidator : AbstractValidator<TDTermCalCanRq> {
        public TDTermCalCanRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
            //RuleFor(x => x.Payload.PreClsOpt).NotEmpty();
        }
    }
    public class TDTermCalCanRs : EsbT24CommonRs {
        public EsbHeaderInfo HeaderInfo { get; set; }
        public TDTermCalCanPayload Payload { get; set; }
    }
    public class TDTermCalCanFTIDRec {
        public string FTID { get; set; }
    }
    public class TDTermCalCanOvrrdRec {
        public string Ovrrd { get; set; }
    }
    public class TDTermCalCanTxnDateRec {
        public string TxntDate { get; set; }
    }
}
