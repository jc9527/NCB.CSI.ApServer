using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Loan {
    [Validator(typeof(LoanEarlyTermSimRqValidator))]
    public class LoanEarlyTermSimRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public LoanEarlyTermSimPayload Payload { get; set; }
    }

    public class LoanEarlyTermSimPayload {
        public string ArrngId { get; set; }
        public string ProdId { get; set; }
        public LoanEarlyTermSimLoanEarlyClsCalInfo LoanEarlyClsCalInfo { get; set; }
        public IEnumerable<LoanEarlyTermSimDescInfo> DescInfo { get; set; }
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

    public class LoanEarlyTermSimLoanEarlyClsCalInfo {
        public string SimClsDate { get; set; }
    }

    public class LoanEarlyTermSimDescInfo {
        public string Desc { get; set; }
    }

    public class LoanEarlyTermSimRqValidator : AbstractValidator<LoanEarlyTermSimRq> {
        public LoanEarlyTermSimRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
        }
    }

    public class LoanEarlyTermSimRs : EsbT24CommonRs {
        public EsbHeaderInfo HeaderInfo { get; set; }
        public IEnumerable<LoanEarlyTermSimqRec> LoanEarlyTermSimqRec { get; set; }
    }

    public class LoanEarlyTermSimqRec {
        public string ArrngId { get; set; }
        public string SimRefNo { get; set; }
        public LoanEarlyTermCalDateAddRec LoanEarlyTermCalDateAddRec { get; set; }
        public LoanEarlyTermCalRsltInqInfo LoanEarlyTermCalRsltInqInfo { get; set; }
        public LoanEarlyTermCalInfo LoanEarlyTermCalInfo { get; set; }
        public IEnumerable<LoanEarlyTermSimLoanEarlyClsCalInqInfo> LoanEarlyClsCalInqInfo { get; set; }
        public IEnumerable<LoanEarlyTermSimOvrrdRec> OvrrdRec { get; set; }
        public IEnumerable<LoanEarlyTermSimTxnDateRec> TxnDateRec { get; set; }
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

    public class LoanEarlyTermCalDateAddRec {
        public IEnumerable<LoanEarlyTermSimCustInfo> CustInfo { get; set; }
        public string ProdId { get; set; }
        public string Ccy { get; set; }
        public string EffDate { get; set; }
        public LoanEarlyTermSimLoanEarlyClsCalInfo LoanEarlyClsCalInfo { get; set; }
    }

    public class LoanEarlyTermSimCustInfo {
        public string CustId { get; set; }
        public string CustRole { get; set; }
    }

    public class LoanEarlyTermCalRsltInqInfo {
        public string Desc { get; set; }
        public IEnumerable<LoanEarlyClsCalRsltInqInfo> LoanEarlyClsCalRsltInqInfo { get; set; }
    }

    public class LoanEarlyClsCalRsltInqInfo {
        public string SimStat { get; set; }
        public IEnumerable<LoanEarlyTermSimSimErrRec> SimErrRec { get; set; }
    }

    public class LoanEarlyTermSimSimErrRec {
        public string ErrSrc { get; set; }
        public string ErrMsg { get; set; }
    }

    public class LoanEarlyTermCalInfo {
        public IEnumerable<LoanEarlyTermSimDescInfo> DescInfo { get; set; }
        public string SimRunDate { get; set; }
        public string SimEndDate { get; set; }
        public string SimExecFlg { get; set; }
        public string Stat { get; set; }
        public IEnumerable<LoanEarlyTermSimSimErrRec> SimErrRec { get; set; }
    }

    public class LoanEarlyTermSimPmtRec {
        public string ClsDate { get; set; }
        public string ClsAmt { get; set; }
        public string ClsIntrstAmt { get; set; }
    }

    public class LoanEarlyTermSimLoanEarlyClsCalInqInfo {
        public string AcctNo { get; set; }
        public IEnumerable<LoanEarlyTermSimLoanEarlyTermCalInqInfo> LoanEarlyTermCalInqInfo { get; set; }
    }

    public class LoanEarlyTermSimLoanEarlyTermCalInqInfo {
        public string SimClsDate { get; set; }
        public string Ccy { get; set; }
        public string UNCPostvAmt1 { get; set; }
        public string ClsAmtExctUNC { get; set; }
        public string ClsAmtInclUNC { get; set; }
        public string CustId { get; set; }
        public string CustName { get; set; }
        public string ProdId { get; set; }
        public IEnumerable<LoanEarlyTermSimClsInfo> SimClsInfo { get; set; }
    }

    public class LoanEarlyTermSimClsInfo {
        public string SimClsTypeAmt { get; set; }
        public string SimClsType { get; set; }
    }

    public class LoanEarlyTermSimOvrrdRec {
        public string Ovrrd { get; set; }
    }

    public class LoanEarlyTermSimTxnDateRec {
        public string TxntDate { get; set; }
    }
}
