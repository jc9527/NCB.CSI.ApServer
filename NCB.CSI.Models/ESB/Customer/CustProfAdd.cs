using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Customer {

    [Validator(typeof(CustProfAddRqValidator))]
    public class CustProfAddRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public CustProfAddCustProfInfo Payload { get; set; }
    }
    public class CustProfAddRqValidator : AbstractValidator<CustProfAddRq> {
        public CustProfAddRqValidator() {
            RuleFor(x => x.Payload).NotEmpty();
            //RuleFor(x => x.Payload.CustEngNameInfo.CustEngName).NotEmpty();
            //RuleFor(x => x.Payload.CustChnNameInfo.CustChnName).NotEmpty();
            //RuleFor(x => x.Payload.NCBExtSysRec).NotEmpty();
            //RuleFor(x => x.Payload.NCBMemoRec).NotEmpty();
            //RuleFor(x => x.Payload.ImgRec).NotEmpty();
            //RuleFor(x => x.Payload.AcctClsRsn).NotEmpty();
            //RuleFor(x => x.Payload.CstdnRec).NotEmpty();
            //RuleFor(x => x.Payload.Rsdnt183Flg).NotEmpty();
            //RuleFor(x => x.Payload.PostRsnRec).NotEmpty();
        }
    }
    public class CustProfAddRs : EsbT24CommonRs {
        public CustProfAddHeaderInfo HeaderInfo { get; set; }
        public CustProfAddCustProfInfo CustProfInfo { get; set; }
    }
    public class CustProfAddCustProfInfo {  
        public CustProfAddCustEngNameInfo CustEngNameInfo { get; set; }
        public CustProfAddCustChnNameInfo CustChnNameInfo { get; set; }
        public CustProfAddCustShrtNameInfo CustShrtNameInfo { get; set; }
        public string Mnem { get; set; }
        public string AOEmplNo { get; set; }
        public string Sctr { get; set; }
        public string Indstry { get; set; }
        public string Tgt { get; set; }
        public string CustStat { get; set; }
        public string Natl { get; set; }
        public string Res { get; set; }
        public string Lang { get; set; }
        public string CustPermId { get; set; }
        public IEnumerable<EsbCntctInfo> CntctDtlsInfo { get; set; }
        public string BirthDay { get; set; }
        public CustProfAddLglDocInfo LglDocInfo { get; set; }
        public string Gndr { get; set; }
        public string MrtlStat { get; set; }
        public IEnumerable<CustProfAddRelnInfo> RelnInfo { get; set; }
        public IEnumerable<CustProfAddEmpl> Empl { get; set; }
        public IEnumerable<CustProfAddResStatRec> ResStatRec { get; set; }
        public IEnumerable<CustProfAddFaxNoRec> FaxNoRec { get; set; }
        public string MGM { get; set; }
        public CustProfAddTWMailAddr TWMailAddr { get; set; }
        public string CustType { get; set; }
        public IEnumerable<CustProfAddNCBExtSysRec> NCBExtSysRec { get; set; }
        public string DeathDate { get; set; }
        public IEnumerable<CustProfAddNCBMemoRec> NCBMemoRec { get; set; }
        public IEnumerable<CustProfAddImgRec> ImgRec { get; set; }
        public IEnumerable<CustProfAddAcctOpnRsnRec> MyProperty { get; set; }
        public IEnumerable<CustProfAddOwnrInfo> OwnrInfo { get; set; }
        public string CptlCcy { get; set; }
        public string CptlAmt { get; set; }
        public string PayinCptlCcy { get; set; }
        public string PayinCptlAmt { get; set; }
        public string OBUMemo { get; set; }
        public CustProfAddCntctInfo CntctInfo { get; set; }
        public string EmplNo { get; set; }
        public string SMEcode { get; set; }
        public string XSellFlg { get; set; }
        public string MKTDate { get; set; }
        public string CRSBirthCntry { get; set; }
        public string CRSBirthCity { get; set; }
        public string LFATCAId { get; set; }
        public IEnumerable<CustProfAddEcoRec> EcoRec { get; set; }
        public EsbAddr MailAddr { get; set; }
        public IEnumerable<CustProfAddCstdnRec> CstdnRec { get; set; }
        public string SpclSignCode { get; set; }
        public string BnkrptDate { get; set; }
        public string SWIFTCode { get; set; }
        public string GuarRec { get; set; }
        public IEnumerable<CustProfAddMKTMark> MKTMark { get; set; }
        public string DgtlAcctVrfy { get; set; }
        public string VrfyAcct { get; set; }
        public string ScrtAcctFlg { get; set; }
        public string CIFCloseDt { get; set; }
        public string TaxFreeFlg { get; set; }
        public string PIPAFlg { get; set; }
        public string VIPCode { get; set; }
        public string LoanGrp { get; set; }
        public string RelnRMCode { get; set; }
        public string FXId { get; set; }
        public string IBMBIndstryType { get; set; }
        public string IndstryCode { get; set; }
        public string PIDIssStat { get; set; }
        public string PIDIssLoc { get; set; }
        public string PIDIssDate { get; set; }
        public string NHIFlg { get; set; }
        public string ReconStat { get; set; }
        public string Rsdnt183Flg { get; set; }
        public string SpclPrsnNote { get; set; }
        public string L3PtyXSellFlg { get; set; }
        public string StkhldrToken { get; set; }
        public EsbAddr RsdntAddr { get; set; }
        public string PinYinName { get; set; }
        public string AcctClsRsn { get; set; }
        public string LoanLmtTtl { get; set; }
        public string SmlAmtXferDate { get; set; }
        public IEnumerable<CustProfAddPostRsnRec> PostRsnRec { get; set; }
        public IEnumerable<EsbAddr> CoAddr { get; set; }
        public IEnumerable<CustProfAddPostRstrctCodeRec> PostRstrctCodeRec { get; set; }
        public string IPAddr { get; set; }
        public string DevNo { get; set; }
        public string GPS { get; set; }
        public string EntryDeptCode { get; set; }
        public string PrftCntr { get; set; }
        public string CostCntr { get; set; }
        public string AuthEmpId { get; set; }
        public string VerName { get; set; }
        public string EcoUnit { get; set; }
        public string APIKey { get; set; }
        public string MobLang { get; set; }
        public string Chan { get; set; }
    }
    public class CustProfAddCustEngNameInfo {
        public string CustEngName { get; set; }
    }
    public class CustProfAddCustChnNameInfo {
        public string CustChnName { get; set; }
    }
    public class CustProfAddCustShrtNameInfo {
        public string CustShrtName { get; set; }
    }
    public class CustProfAddLglDocInfo {
        public string LglDocId { get; set; }
        public string LglDocName { get; set; }
        public string LglDocHldrName { get; set; }
        public string LglDocIssAuthDate { get; set; }
        public string LglDocIssDate { get; set; }
        public string LglDocExpDate { get; set; }
    }
    public class CustProfAddRelnInfo {
        public string RelnCustId { get; set; }
        public string RelnCode { get; set; }
    }
    public class CustProfAddEmpl {
        public string EmplStat { get; set; }
        public string Ocptn { get; set; }
        public string JobTitl { get; set; }
        public string EmpCoName { get; set; }
        public IEnumerable<CustProfAddEmpCoAddrRec> EmpCoAddrRec { get; set; }
        public string EmpCoBuss { get; set; }
        public string EmplDate { get; set; }
        public string SlryCcy { get; set; }
        public string Slry { get; set; }
        public string AnlBonus { get; set; }
        public string SlryFreq { get; set; }
    }
    public class CustProfAddEmpCoAddrRec {
        public string CoAddr { get; set; }
    }
    public class CustProfAddResStatRec {
        public string ResStat { get; set; }
        public string ResType { get; set; }
    }
    public class CustProfAddFaxNoRec {
        public string FaxNo { get; set; }
    }
    public class CustProfAddTWMailAddr {
        public string TWAddrZip { get; set; }
        public string TWSt { get; set; }
        public string TWAddr { get; set; }
        public string TWTownCnty { get; set; }
        public string TWCnty { get; set; }
    }
    public class CustProfAddNCBExtSysRec {
        public string NCBExtSysId { get; set; }
        public string NCBExtCustId { get; set; }
    }
    public class CustProfAddNCBMemoRec {
        public string NCBMemo { get; set; }
    }
    public class CustProfAddImgRec {
        public string ImgLoc { get; set; }
        public string ImgRefNo { get; set; }
    }
    public class CustProfAddAcctOpnRsnRec {
        public string AcctOpnRsn { get; set; }
        public string EduLvl { get; set; }
        public string IndstryType { get; set; }
        public string IndstryObj { get; set; }
        public string GrpCo { get; set; }
        public string EmplYears { get; set; }
        public string YearIncm { get; set; }
        public string YearIncmDate { get; set; }
    }
    public class CustProfAddOwnrInfo {
        public string CoId { get; set; }
        public string BirthDate { get; set; }
        public string Name { get; set; }
        public string Gndr { get; set; }
        public string Cntry { get; set; }
    }
    public class CustProfAddCntctInfo {
        public string Name { get; set; }
        public string Title { get; set; }
        public string LostCntctCode { get; set; }
        public string Phone { get; set; }
    }
    public class CustProfAddEcoRec {
        public string EcoType { get; set; }
        public string EcoId { get; set; }
        public string EcoDate { get; set; }
        public string EcoNextId { get; set; }
    }
    public class CustProfAddCstdnRec {
        public string Cstdn { get; set; }
    }
    public class CustProfAddMKTMark {
        public string MKTWill { get; set; }
        public string MKTType { get; set; }
        public string MKTUpdtDate { get; set; }
        public string MKTUpdtChan { get; set; }
        public string MKTUpdtEmplId { get; set; }

    }
    public class CustProfAddPostRsnRec {
        public string PostRsn { get; set; }
        public string PostRstrctAppDate { get; set; }
        public string RlsPostRstrctRsn { get; set; }
        public string PostRstrctRlsDate { get; set; }
    }
    public class CustProfAddPostRstrctCodeRec {
        public string PostRstrctCode { get; set; }
    }
    public class CustProfAddHeaderInfo {
        public string Id { get; set; }
        public string TxnStat { get; set; }
        public EsbAudit Audit { get; set; }
    }
}
