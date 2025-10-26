using Devpro.Shared.Misc.Newtonsoft;
using FluentValidation;
using FluentValidation.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Customer {
    [Validator(typeof(CustProfModRqValidator))]
    public class CustProfModRq : EsbRqServiceBody {
        public bool? ValidateOnly { get; set; }
        public CustProfModCustProfInfo CustProfInfo { get; set; }
    }

    public class CustProfModRqValidator : AbstractValidator<CustProfModRq> {
        public CustProfModRqValidator() {
            RuleFor(x => x.CustProfInfo).NotEmpty();
            //RuleFor(x => x.CustProfInfo.CIFNo).NotEmpty();
            //RuleFor(x => x.CustProfInfo.CustEngNameInfo.CustEngName).NotEmpty();
            //RuleFor(x => x.CustProfInfo.CustChnNameInfo.CustChnName).NotEmpty();
            //RuleFor(x => x.CustProfInfo.NCBExtSysRec).NotEmpty();
            //RuleFor(x => x.CustProfInfo.NCBMemoRec).NotEmpty();
            //RuleFor(x => x.CustProfInfo.ImgRec).NotEmpty();
            //RuleFor(x => x.CustProfInfo.AcctClsRsn).NotEmpty();
            //RuleFor(x => x.CustProfInfo.CstdnRec).NotEmpty();
            //RuleFor(x => x.CustProfInfo.Rsdnt183Flg).NotEmpty();
            //RuleFor(x => x.CustProfInfo.PostRsnRec).NotEmpty();
        }
    }

    public class CustProfModRs : EsbT24CommonRs {
        public EsbHeaderInfo HeaderInfo { get; set; }
        public CustProfModCustProfInfo CustInfo { get; set; }
    }

    public class CustProfModCustProfInfo {
        public string CIFNo { get; set; }
        public string CustEngName { get; set; }
        public string CustChnName { get; set; }
        public IEnumerable<CustProfModCustShrtNameInfo> CustShrtNameInfo { get; set; }
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
        public IEnumerable<CustProfModLglDocInfo> LglDocInfo { get; set; }
        public string Gndr { get; set; }
        public string MrtlStat { get; set; }
        public IEnumerable<CustProfModRelnInfo> RelnInfo { get; set; }
        public IEnumerable<CustProfModEmpl> Empl { get; set; }
        public IEnumerable<CustProfModResStatRec> ResStatRec { get; set; }
        public IEnumerable<CustProfModFaxNoRec> FaxNoRec { get; set; }
        public string MGM { get; set; }
        public IEnumerable<CustProfModTWMailAddr> TWMailAddr { get; set; }
        public string CustType { get; set; }
        public IEnumerable<CustProfModNCBExtSysRec> NCBExtSysRec { get; set; }
        public string DeathDate { get; set; }
        public IEnumerable<CustProfModNCBMemoRec> NCBMemoRec { get; set; }
        public IEnumerable<CustProfModImgRec> ImgRec { get; set; }
        public IEnumerable<CustProfModAcctOpnRsnRec> MyProperty { get; set; }
        public IEnumerable<CustProfModOwnrInfo> OwnrInfo { get; set; }
        public string CptlCcy { get; set; }
        public string CptlAmt { get; set; }
        public string PayinCptlCcy { get; set; }
        public string PayinCptlAmt { get; set; }
        public string OBUMemo { get; set; }
        public IEnumerable<CustProfModCntctInfo> CntctInfo { get; set; }
        public string EmplNo { get; set; }
        public string SMEcode { get; set; }
        public string XSellFlg { get; set; }
        public string MKTDate { get; set; }
        public string CRSBirthCntry { get; set; }
        public string CRSBirthCity { get; set; }
        public string LFATCAId { get; set; }
        public IEnumerable<CustProfModEcoRec> EcoRec { get; set; }
        public IEnumerable<CustProfModMailAddr> MailAddr { get; set; }
        public IEnumerable<EsbEngAddr> EngAddrRec { get; set; }
        public IEnumerable<CustProfModCstdnRec> CstdnRec { get; set; }
        public string SpclSignCode { get; set; }
        public string BnkrptDate { get; set; }
        public string SWIFTCode { get; set; }
        public string GuarRec { get; set; }
        public IEnumerable<CustProfModMKTMark> MKTMark { get; set; }
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
        public IEnumerable<CustProfModPostRsnRec> PostRsnRec { get; set; }
        public IEnumerable<EsbAddr> CoAddr { get; set; }
        public IEnumerable<CustProfModPostRstrctCodeRec> PostRstrctCodeRec { get; set; }
        public IEnumerable<CustProfModDsbltyCardTypeRec> DsbltyCardTypeRec { get; set; }
        public string DsbltyCardExpDate { get; set; }
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

    public class CustProfModCustShrtNameInfo {
        public string CustShrtName { get; set; }
    }

    public class CustProfModLglDocInfo {
        public string LglDocId { get; set; }
        public string LglDocName { get; set; }
        public string LglDocHldrName { get; set; }
        public string LglDocIssAuthDate { get; set; }
        public string LglDocIssDate { get; set; }
        public string LglDocExpDate { get; set; }
    }

    public class CustProfModRelnInfo {
        public string RelnCustId { get; set; }
        public string RelnCode { get; set; }
    }

    public class CustProfModEmpl {
        public string EmplStat { get; set; }
        public string Ocptn { get; set; }
        public string JobTitl { get; set; }
        public string EmpCoName { get; set; }
        public IEnumerable<CustProfModCoAddrRec> EmpCoAddrRec { get; set; }
        public string EmpCoBuss { get; set; }
        public string EmplDate { get; set; }
        public string SlryCcy { get; set; }
        public string Slry { get; set; }
        public string AnlBonus { get; set; }
        public string SlryFreq { get; set; }
    }

    public class CustProfModCoAddrRec {
        public string EmpCoAddr { get; set; }
    }

    public class CustProfModResStatRec {
        public string ResStat { get; set; }
        public string ResType { get; set; }
    }

    public class CustProfModFaxNoRec {
        public string FaxNo { get; set; }
    }

    public class CustProfModTWMailAddr {
        public string TWAddrZip { get; set; }
        public string TWSt { get; set; }
        public string TWAddr { get; set; }
        public string TWTownCnty { get; set; }
        public string TWCnty { get; set; }
    }

    public class CustProfModMailAddr {
        public string AddrZip { get; set; }
        public string St { get; set; }
        public string Addr { get; set; }
        public string TownCnty { get; set; }
        public string Cntry { get; set; }
    }

    public class CustProfModNCBExtSysRec {
        public string NCBExtSysId { get; set; }
        public string NCBExtCustId { get; set; }
    }

    public class CustProfModNCBMemoRec {
        public string NCBMemo { get; set; }
    }

    public class CustProfModImgRec {
        public string ImgLoc { get; set; }
        public string ImgRefNo { get; set; }
    }

    public class CustProfModAcctOpnRsnRec {
        public string AcctOpnRsn { get; set; }
        public string EduLvl { get; set; }
        public string IndstryType { get; set; }
        public string IndstryObj { get; set; }
        public string GrpCo { get; set; }
        public string EmplYears { get; set; }
        public string YearIncm { get; set; }
        public string YearIncmDate { get; set; }
    }

    public class CustProfModOwnrInfo {
        public string CoId { get; set; }
        public string BirthDate { get; set; }
        public string Name { get; set; }
        public string Gndr { get; set; }
        public string Cntry { get; set; }
    }

    public class CustProfModCntctInfo {
        public string Name { get; set; }
        public string Title { get; set; }
        public string LostCntctCode { get; set; }
        public string Phone { get; set; }
    }

    public class CustProfModEcoRec {
        public string EcoType { get; set; }
        public string EcoId { get; set; }
        public string EcoDate { get; set; }
        public string EcoNextId { get; set; }
    }

    public class CustProfModCstdnRec {
        public string Cstdn { get; set; }
    }

    public class CustProfModMKTMark {
        public string MKTWill { get; set; }
        public string MKTType { get; set; }
        public string MKTUpdtDate { get; set; }
        public string MKTUpdtChan { get; set; }
        public string MKTUpdtEmplId { get; set; }

    }

    public class CustProfModPostRsnRec {
        public string PostRsn { get; set; }
        public string PostRstrctAppDate { get; set; }
        public string RlsPostRstrctRsn { get; set; }
        public string PostRstrctRlsDate { get; set; }
    }

    public class CustProfModPostRstrctCodeRec {
        public string PostRstrctCode { get; set; }
    }

    public class CustProfModDsbltyCardTypeRec {
        public string DsbltyCardType { get; set; }
    }
}
