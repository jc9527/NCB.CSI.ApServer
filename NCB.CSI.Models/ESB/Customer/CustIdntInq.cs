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
    [Validator(typeof(CustIdntInqRqValidator))]
    public class CustIdntInqRq : EsbInqCommonRq {
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string MobNo { get; set; }
        public string eMailAddr { get; set; }
    }

    public class CustIdntInqRqValidator : AbstractValidator<CustIdntInqRq> {
        public CustIdntInqRqValidator() {
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.MobNo) && string.IsNullOrWhiteSpace(x.eMailAddr));
            RuleFor(x => x.MobNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId) && string.IsNullOrWhiteSpace(x.eMailAddr));
            RuleFor(x => x.eMailAddr).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId) && string.IsNullOrWhiteSpace(x.MobNo));
        }
    }

    public class CustIdntInqRs : EsbT24InqCommonRs {
        public IEnumerable<CustIdntInqCustInfo> CustInfo { get; set; }
    }

    public class CustIdntInqCustInfo {
        public string CustPermId { get; set; }
        public string CIFNo { get; set; }
        public IEnumerable<CustIdntInqCustRec> CustRec { get; set; }
    }

    public class CustIdntInqCustRec {
        public string CustChnName { get; set; }
        public string CustEngName { get; set; }
        public EsbAddr RsdntAddr { get; set; }
        public IEnumerable<EsbAddr> MailAddr { get; set; }
        public IEnumerable<EsbCntctInfo> CntctDtlsInfo { get; set; }
        public string DgtlAcctVrfy { get; set; }
        public string EntryEmplNo { get; set; }
        public string CIFAddDate { get; set; }
        public string CIFCloseDt { get; set; }
        public IEnumerable<EsbPostRstrctRsnRec> PostRstrctRsnRec { get; set; }
    }
}
