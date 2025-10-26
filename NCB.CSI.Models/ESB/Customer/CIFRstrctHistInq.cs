using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Customer {
    [Validator(typeof(CIFRstrctHistInqRqValidator))]
    public class CIFRstrctHistInqRq : EsbInqCommonRq {
        public string CustPermId { get; set; }
        public string CIFNo { get; set; }
        public string PostRstrctCode { get; set; }
    }
    public class CIFRstrctHistInqRqValidator : AbstractValidator<CIFRstrctHistInqRq> {
        public CIFRstrctHistInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CIFNo) && string.IsNullOrWhiteSpace(x.PostRstrctCode));
            RuleFor(x => x.CIFNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId) && string.IsNullOrWhiteSpace(x.PostRstrctCode));
            RuleFor(x => x.PostRstrctCode).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CIFNo) && string.IsNullOrWhiteSpace(x.CustPermId));
        }
    }
    public class CIFRstrctHistInqRs : EsbNonT24CommonRs {
        public CIFRstrctHistInqAudit Audit { get; set; }
        public IEnumerable<CIFRstrctHistInqCIFRstrctInfo> CIFRstrctInfo { get; set; }
    }
    public class CIFRstrctHistInqAudit {
        public string T24Time { get; set; }
        public string VerNo { get; set; }
        public string ReqParseTime { get; set; }
        public string ResParseTime { get; set; }
    }
    public class CIFRstrctHistInqCIFRstrctInfo {
        public string CIFNo { get; set; }
        public string CustPermId { get; set; }
        public IEnumerable<CIFRstrctHistInqCIFRstrcRec> CIFRstrcRec { get; set; }
    }
    public class CIFRstrctHistInqCIFRstrcRec {
        public string Mnem { get; set; }
        public IEnumerable<CIFRstrctHistInqCustShrtNameRec> CustShrtNameRec { get; set; }
        public IEnumerable<CIFRstrctHistInqPostRstrctCodeRec> PostRstrctCodeRec { get; set; }
        public IEnumerable<CIFRstrctHistInqPostRstrctRsnRec> PostRstrctRsnRec { get; set; }
        public IEnumerable<CIFRstrctHistInqPostRstrctTypeRec> PostRstrctTypeRec { get; set; }
        public IEnumerable<CIFRstrctHistInqPostRsnRec> PostRsnRec { get; set; }
        public IEnumerable<CIFRstrctHistInqAppDateRec> AppDateRec { get; set; }
        public IEnumerable<CIFRstrctHistInqPostRstrctRlsRsnRec> PostRstrctRlsRsnRec { get; set; }
        public IEnumerable<CIFRstrctHistInqPostRstrctRlsDateRec> PostRstrctRlsDateRec { get; set; }
    }
    public class CIFRstrctHistInqCustShrtNameRec {
        public string CustShrtName { get; set; }
    }
    public class CIFRstrctHistInqPostRstrctCodeRec { public string PostRstrctCode { get; set; } }
    public class CIFRstrctHistInqPostRstrctRsnRec { public string PostRstrctRsn { get; set; } }
    public class CIFRstrctHistInqPostRstrctTypeRec { public string PostRstrctType { get; set; } }
    public class CIFRstrctHistInqPostRsnRec { public string PostRsn { get; set; } }
    public class CIFRstrctHistInqAppDateRec { public string AppDate { get; set; } }
    public class CIFRstrctHistInqPostRstrctRlsRsnRec { public string PostRstrctRlsRsn { get; set; } }
    public class CIFRstrctHistInqPostRstrctRlsDateRec { public string PostRstrctRlsDate { get; set; } }
}
