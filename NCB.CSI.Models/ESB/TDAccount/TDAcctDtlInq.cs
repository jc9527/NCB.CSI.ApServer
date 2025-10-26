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

namespace NCB.CSI.Models.ESB.TDAccount {
    [Validator(typeof(TDAcctDtlInqRqValidator))]
    public class TDAcctDtlInqRq : EsbInqCommonRq {
        public string ArrngId { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        [LogItem("AccountNo")]
        public string TDAcctNo { get; set; }
    }

    public class TDAcctDtlInqRqValidator : AbstractValidator<TDAcctDtlInqRq> {
        public TDAcctDtlInqRqValidator() {
            RuleFor(x => x.ArrngId).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.TDAcctNo) && string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.TDAcctNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.ArrngId) && string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.ArrngId) && string.IsNullOrWhiteSpace(x.TDAcctNo));
        }
    }

    public class TDAcctDtlInqRs : EsbT24InqCommonRs {
        public IEnumerable<TDAcctDtlInqTDAcctRec> TDAcctRec { get; set; }
    }

    public class TDAcctDtlInqTDAcctRec {
        public string ArrngId { get; set; }
        public string CustPermId { get; set; }
        public string TDAcctNo { get; set; }
        public string CIFNo { get; set; }
        public IEnumerable<TDAcctDtlInqTDacctDtlInfo> TDacctDtlInfo { get; set; }
    }

    public class TDAcctDtlInqTDacctDtlInfo {
        public string CustEngName { get; set; }
        public string CustChnName { get; set; }
        public TDAcctDtlInqRsdntAddr RsdntAddr { get; set; }
        public string eMailAddr { get; set; }
        public string MobNo { get; set; }
        public string ProdName { get; set; }
        public string Ccy { get; set; }
        public string TDAmt { get; set; }
        public string IntrstRate { get; set; }
        public string CtrctDate { get; set; }
        public string MtrtyDate { get; set; }
        public string Term { get; set; }
        public string TDAutoRollOvrFlg { get; set; }
        public string RollOvrType { get; set; }
        public string AutoRollOvrDate { get; set; }
        public string TDCtrctCanRsn { get; set; }
        public string AcctStatCode { get; set; }
        public string FltRateFlg { get; set; }
    }

    public class TDAcctDtlInqRsdntAddr {
        public string AddrZip { get; set; }
        public string Cntry { get; set; }
        public string TownCnty { get; set; }
        public string St { get; set; }
        public string Addr { get; set; }
    }
}
