using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devpro.Shared.Attributies;
using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using Newtonsoft.Json;

namespace NCB.CSI.Models.ESB.Customer {
    [Validator(typeof(CustSummInqRqValidator))]
    public class CustSummInqRq : EsbInqCommonRq {
        [LogItem("AccountNo")]
        public string AcctId { get; set; }
        public string CIFNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
    }

    public class CustSummInqRqValidator : AbstractValidator<CustSummInqRq> {
        public CustSummInqRqValidator() {
            RuleFor(x => x.AcctId).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CIFNo) && string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CIFNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.AcctId) && string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.AcctId) && string.IsNullOrWhiteSpace(x.CIFNo));
        }
    }

    public class CustSummInqRs : EsbT24InqCommonRs {
        [JsonConverter(typeof(ArrayToSingleConverter<CustSummInqCustSummInfo>))]
        public CustSummInqCustSummInfo CustSummInfo { get; set; }
    }

    public class CustSummInqCustSummInfo {
        public string PageKey { get; set; }
        public string CustPermId { get; set; }
        public string CIFNo { get; set; }
        public CustSummInqCustInfo CustInfo { get; set; }
        public IEnumerable<CustSummInqAcctRec> AcctRec { get; set; }
    }

    public class CustSummInqCustInfo {
        public string CustPermId { get; set; }
        public string CIFNo { get; set; }
        public string CustEngName { get; set; }
        public string CustChnName { get; set; }
        public string Gndr { get; set; }
        public string Token { get; set; }
        public string LIndstry { get; set; }
        public string LIndstryObj { get; set; }
        public string BirthDay { get; set; }
        public string Natl { get; set; }
        public IEnumerable<EsbCntctInfo> CntctInfo { get; set; }
        public IEnumerable<CustSummInqOffPhnNoRec> OffPhnNoRec { get; set; }
        public string Sctr { get; set; }
        public string CustStat { get; set; }
        public IEnumerable<EsbAddr> MailAddr { get; set; }
        public EsbAddr RsdntAddr { get; set; }
        public string EduLvl { get; set; }
        public string GrpCo { get; set; }
        public IEnumerable<EsbAddr> CoAddr { get; set; }
        public IEnumerable<EsbEcoRec> EcoRec { get; set; }
        public string DgtlAcctVrfy { get; set; }
        public string EntryEmplNo { get; set; }
        public string CIFAddDate { get; set; }
        public string CIFCloseDt { get; set; }
        public IEnumerable<EsbPostRstrctRsnRec> PostRstrctRsnRec { get; set; }
        public string LoanLmtTtl { get; set; }
        public IEnumerable<EsbPostRstrctRec> CustPostRstrctRec { get; set; }
    }

    public class CustSummInqAcctRec {
        public string ArrngId { get; set; }
        public string AcctId { get; set; }
        public string AcctName { get; set; }
        public string AcctAddName { get; set; }
        public string DisplayName { get; set; }
        public string AcctCcy { get; set; }
        public string LockAmt { get; set; }
        public string WorkBal { get; set; }
        public string OnlineActualBal { get; set; }
        public string AvailBal { get; set; }
        public string ProdtName { get; set; }
        public string DgtlLvl { get; set; }
        public string RefNo { get; set; }
        public string LmtProdId { get; set; }
        public string LmtAmt { get; set; }
        public string AvailLmtAmt { get; set; }
        public string DueDate { get; set; }
        public string OvdStat { get; set; }
        public string OpnDate { get; set; }
        public string ClrBal { get; set; }
        public IEnumerable<EsbPostRstrctRec> PostRstrctRec { get; set; }
        public string AcctMaxBal { get; set; }
    }

    public class CustSummInqOffPhnNoRec {
        public string OffPhnNo { get; set; }
    }
}
