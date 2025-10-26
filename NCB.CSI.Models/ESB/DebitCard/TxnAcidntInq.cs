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

namespace NCB.CSI.Models.ESB.DebitCard {
    [Validator(typeof(TxnAcidntInqRqValidator))]
    public class TxnAcidntInqRq : EsbDebitCardInqCommonRq {
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        [LogItem("CustId")]
        public string CustPermId { get; set; }
        public string StartTxnDate { get; set; }
        public string EndTxnDate { get; set; }
    }

    public class TxnAcidntInqRqValidator : AbstractValidator<TxnAcidntInqRq> {
        public TxnAcidntInqRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty().When(x => string.IsNullOrWhiteSpace(x.CustPermId));
            RuleFor(x => x.CustPermId).NotEmpty().Matches(RegExConst.TwNid).When(x => string.IsNullOrWhiteSpace(x.CardNo));
            RuleFor(x => x.StartTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
            RuleFor(x => x.EndTxnDate).NotEmpty().Matches(RegExConst.YYYYMMDD);
        }
    }

    public class TxnAcidntInqRs : EsbNonT24CommonRs {
        public IEnumerable<TxnAcidntInqCardNoRec> CardNoRec { get; set; }
        public TxnAcidntInqControlRec ControlRec { get; set; }
    }

    public class TxnAcidntInqCardNoRec {
        public string BillNo { get; set; }
        public string PostDate { get; set; }
        public string TxnDate { get; set; }
        public string CardNo { get; set; }
        public string AmtCcy { get; set; }
        public string OrigAmt { get; set; }
        public string TWDAmt { get; set; }
        public string MrchName { get; set; }
        public string MrchCity { get; set; }
        public string AuthKey { get; set; }
        public string TxnCode { get; set; }
        public string RiskType { get; set; }
        public string CntlrNo { get; set; }
        public string RtrvlReqFlg { get; set; }
        public string ChrgbckFlg { get; set; }
        public string PrbTxnFlg { get; set; }
        public string XbrdrOrgType { get; set; }
        public string LockSeqNo { get; set; }
        public string PrbSrcCode { get; set; }
        public string PrbTxnType { get; set; }
        public string PrbTxnAmt { get; set; }
        public string PrbTxnStat { get; set; }
        public string PrbTxnRsnCode { get; set; }
        public string PrbTxnDesc { get; set; }
        public string FrdRptFlg { get; set; }
        public string PrbTxnAddDate { get; set; }
        public string PrbTxnAddUserId { get; set; }
        public string PrbTxnAddCntlDate { get; set; }
        public string PrbTxnAddCntlrId { get; set; }
        public string PrbTxnClsDate { get; set; }
        public string PrbTxnClsUserId { get; set; }
        public string PrbTxnClsCntlDate { get; set; }
        public string PrbTxnClsCntlrId { get; set; }
        public string PrbClsRslt { get; set; }
        public string PrbOrgCardNo { get; set; }
        public string PrbMchtRePayAmt { get; set; }
        public string RtrvlReqSeqNo { get; set; }
        public string StatCode { get; set; }
        public string RtrvlReqType { get; set; }
        public string RtrvlReqRsnCode { get; set; }
        public string RctSendFlg { get; set; }
        public string RctLastRtrnDate { get; set; }
        public string RctRcvDate { get; set; }
        public string RctSendDate { get; set; }
        public string RctRjctFlg { get; set; }
        public string RctRjctDate { get; set; }
        public string RtrvlReqRslt { get; set; }
        public string RtrvlReqAddDate { get; set; }
        public string RtrvlReqAddUserId { get; set; }
        public string RtrvlReqClsDate { get; set; }
        public string RtrvlReqClsUserId { get; set; }
        public string DbStage { get; set; }
        public string DbSubStage { get; set; }
        public string DbClsFlg { get; set; }
        public string DbRsnCode { get; set; }
        public string DbClsAddDate { get; set; }
        public string DbClsAddUserId { get; set; }
        public string FrstDbStatCode { get; set; }
        public string FrstDbResndFlg { get; set; }
        public string FrstDbDivFlg { get; set; }
        public string FrstDbTWDAmt { get; set; }
        public string FrstDbAmt { get; set; }
        public string PrtlDbFlg { get; set; }
        public string FrstDbRsnCode { get; set; }
        public string FirstDocPrntFlg { get; set; }
        public string FrstDbExpDate { get; set; }
        public string FrstDbMsg { get; set; }
        public string FrstDbSendDate { get; set; }
        public string FrstDbAddDate { get; set; }
        public string FrstDbAddUserId { get; set; }
        public string FrstDbDsbrAmt { get; set; }
        public string FrstDbDsbrAddUserId { get; set; }
        public string FrstDbDsbrAddDate { get; set; }
        public string PrmptStat { get; set; }
        public string PrmptDocFlg { get; set; }
        public string PrmptMsg { get; set; }
        public string PrmptSentDate { get; set; }
        public string PrmptAmt { get; set; }
        public string PrmptExpDate { get; set; }
        public string PrmptAddDate { get; set; }
        public string PrmptAddUserId { get; set; }
        public string ScndDbStat { get; set; }
        public string ScndDbResndFlg { get; set; }
        public string ScndDbDivFlg { get; set; }
        public string ScndDbTWDAmt { get; set; }
        public string ScndDbAmt { get; set; }
        public string PrtlScndDbFlg { get; set; }
        public string ScndDbRsnCode { get; set; }
        public string ScndDbExpDate { get; set; }
        public string ScndDbMsg { get; set; }
        public string ScndDbSendDate { get; set; }
        public string ScndDbAddDate { get; set; }
        public string ScndDbAddUserId { get; set; }
        public string ScndDbDsbrAmt { get; set; }
        public string ScndDbDsbrDate { get; set; }
        public string ScndDbDsbrUserId { get; set; }
        public string ScndDbDsbrFlg { get; set; }
        public string ScndDbUsageCode { get; set; }
        public string PreArbitStat { get; set; }
        public string PreArbitDate { get; set; }
        public string PreArbitExpDate { get; set; }
        public string PreArbitAddDate { get; set; }
        public string PreArbitAddUserId { get; set; }
        public string ArbitStatus { get; set; }
        public string ArbitDate { get; set; }
        public string ArbitExpDate { get; set; }
        public string ArbitAddDate { get; set; }
        public string ArbitAddUserId { get; set; }
    }

    public class TxnAcidntInqControlRec {
        public string CurPage { get; set; }
        public string NoOfCurPage { get; set; }
        public string TtlPageNo { get; set; }
        public string NoOfRec { get; set; }
    }
}
