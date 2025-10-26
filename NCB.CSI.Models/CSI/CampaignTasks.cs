using NCB.CSI.Models.BMS.CreateAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CSI {
    public class CampaignTasksRq
    {
        public long TaskId { get; set; }
        public string CampaignCode { get; set; }
        public string WaveCode { get; set; }
        public string DepartmentCode { get; set; }
        public string CustId { get; set; }
        public string MobileNo { get; set; }
        public string TaskTag1 { get; set; }
        public string JsonData { get; set; }
        public string ChineseName { get; set; }
        public int Gender { get; set; }
        public DateTime? DOB { get; set; }
        public string CorrespondenceTelNo { get; set; }
        public string CorrespondenceExt { get; set; }
        public string PermanentTelNo { get; set; }
        public string PermanentExt { get; set; }
        public string ResidentialTelNo { get; set; }
        public string ResidentialExt { get; set; }
        public string CompanyTelNo { get; set; }
        public string CompanyExt { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string FaxNo { get; set; }
        public string CorrespondenceZip { get; set; }
        public string CorrespondenceAddress { get; set; }
        public string PermanentZip { get; set; }
        public string PermanentAddress { get; set; }
        public string ResidentialZip { get; set; }
        public string ResidentialAddress { get; set; }
        public string CompanyZip { get; set; }
        public string CompanyAddress { get; set; }
        public string OtherTelNo1 { get; set; }
        public string OtherTelNo2 { get; set; }
        public string OtherTelNo3 { get; set; }
        public int Int01 { get; set; }
        public int Int02 { get; set; }
        public int Int03 { get; set; }
        public int Int04 { get; set; }
        public int Int05 { get; set; }
        public int Int06 { get; set; }
        public int Int07 { get; set; }
        public int Int08 { get; set; }
        public int Int09 { get; set; }
        public int Int10 { get; set; }
        public int Int11 { get; set; }
        public int Int12 { get; set; }
        public int Int13 { get; set; }
        public int Int14 { get; set; }
        public int Int15 { get; set; }
        public int Int16 { get; set; }
        public int Int17 { get; set; }
        public int Int18 { get; set; }
        public int Int19 { get; set; }
        public int Int20 { get; set; }
        public string Data01 { get; set; }
        public string Data02 { get; set; }
        public string Data03 { get; set; }
        public string Data04 { get; set; }
        public string Data05 { get; set; }
        public string Data06 { get; set; }
        public string Data07 { get; set; }
        public string Data08 { get; set; }
        public string Data09 { get; set; }
        public string Data10 { get; set; }
        public string Data11 { get; set; }
        public string Data12 { get; set; }
        public string Data13 { get; set; }
        public string Data14 { get; set; }
        public string Data15 { get; set; }
        public string Data16 { get; set; }
        public string Data17 { get; set; }
        public string Data18 { get; set; }
        public string Data19 { get; set; }
        public string Data20 { get; set; }
        public string Data21 { get; set; }
        public string Data22 { get; set; }
        public string Data23 { get; set; }
        public string Data24 { get; set; }
        public string Data25 { get; set; }
        public string Data26 { get; set; }
        public string Data27 { get; set; }
        public string Data28 { get; set; }
        public string Data29 { get; set; }
        public string Data30 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastContactDate { get; set; }
        public string ResultCode { get; set; }
        public string Note { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string CreatedBy { get; set; }
    }

    public class CampaignTasksRs
    {
        public int AffectedRowCount { get; set; }
    }
}
