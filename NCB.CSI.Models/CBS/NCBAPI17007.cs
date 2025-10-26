using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CBS {
    [Validator(typeof(NCBAPI17007RqValidator))]
    public class NCBAPI17007Rq {
        public string ncbQryAcctNo { get; set; }
    }

    public class NCBAPI17007RqValidator : AbstractValidator<NCBAPI17007Rq> {
        public NCBAPI17007RqValidator() {
            RuleFor(x => x.ncbQryAcctNo).NotEmpty();
        }
    }

    public class NCBAPI17007Rs : CbsCommonRs {
        public IEnumerable<NCBAPI17007RsBody> body { get; set; }
    }

    public class NCBAPI17007RsBody {
        public string ncbEJsonKey { get; set; }
        public IEnumerable<NCBAPI17007RsBodyResult> results { get; set; }
    }

    public class NCBAPI17007RsBodyResult {
        public string ncbEEvtDesc { get; set; }
        public string ncbEArrId { get; set; }
        public string ncbEProduct { get; set; }
        public string ncbELockAmt { get; set; }
        public string ncbECustId { get; set; }
        public string ncbECustName { get; set; }
        public string ncbEEvtType { get; set; }
        public string ncbELockData { get; set; }
        public string ncbEApplyDate { get; set; }
        public string ncbEAcctNo { get; set; }
        public string ncbELockId { get; set; }
    }
}
