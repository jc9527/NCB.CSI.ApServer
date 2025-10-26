using Dapper;
using NCB.CSI.Models.CSI;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace NCB.CSI.Batch.WTM
{
    class ImportCampaignTasks
    {
        string connection = string.Empty;
        public ImportCampaignTasks()
        {
            connection = ConfigurationManager.ConnectionStrings["WebTM"].ConnectionString;
        }

        public async Task<CampaignTasksRs> ImportCampaignTasksAsync(CampaignTasksRq model)
        {
            var sql = " insert CampaignTasks(CampaignCode, WaveCode, DepartmentCode, CustId, MobileNo, TaskTag1, JsonData, ChineseName, Gender, DOB, CorrespondenceTelNo,";
            sql += " CorrespondenceExt, PermanentTelNo, PermanentExt, ResidentialTelNo, ResidentialExt, CompanyTelNo, CompanyExt, FaxNo,";
            sql += " Email1, Email2, CorrespondenceZip, CorrespondenceAddress, PermanentZip, PermanentAddress, ResidentialZip, ResidentialAddress,";
            sql += " CompanyZip, CompanyAddress, Note, OtherTelNo1, OtherTelNo2, OtherTelNo3,";
            sql += " Int01, Int02, Int03, Int04, Int05, Int06, Int07, Int08, Int09, Int10,";
            sql += " Int11, Int12, Int13, Int14, Int15, Int16, Int17, Int18, Int19, Int20,";
            sql += " Data01, Data02, Data03, Data04, Data05, Data06, Data07, Data08, Data09, Data10,";
            sql += " Data11, Data12, Data13, Data14, Data15, Data16, Data17, Data18, Data19, Data20,";
            sql += " Data21, Data22, Data23, Data24, Data25, Data26, Data27, Data28, Data29, Data30,";
            sql += " CreatedAt)";
            sql += " values(@CampaignCode, @WaveCode, @DepartmentCode, @CustId, @MobileNo, @TaskTag1, @JsonData, @ChineseName, @Gender, @DOB, @CorrespondenceTelNo,";
            sql += " @CorrespondenceExt, @PermanentTelNo, @PermanentExt, @ResidentialTelNo, @ResidentialExt, @CompanyTelNo, @CompanyExt, @FaxNo,";
            sql += " @Email1, @Email2, @CorrespondenceZip, @CorrespondenceAddress, @PermanentZip, @PermanentAddress, @ResidentialZip, @ResidentialAddress,";
            sql += " @CompanyZip, @CompanyAddress, @Note, @OtherTelNo1, @OtherTelNo2, @OtherTelNo3,";
            sql += " @Int01, @Int02, @Int03, @Int04, @Int05, @Int06, @Int07, @Int08, @Int09, @Int10,";
            sql += " @Int11, @Int12, @Int13, @Int14, @Int15, @Int16, @Int17, @Int18, @Int19, @Int20,";
            sql += " @Data01, @Data02, @Data03, @Data04, @Data05, @Data06, @Data07, @Data08, @Data09, @Data10,";
            sql += " @Data11, @Data12, @Data13, @Data14, @Data15, @Data16, @Data17, @Data18, @Data19, @Data20,";
            sql += " @Data21, @Data22, @Data23, @Data24, @Data25, @Data26, @Data27, @Data28, @Data29, @Data30,";
            sql += "  @CreatedAt)";
            using (var cn = new SqlConnection(connection))
            {
                var rs = new CampaignTasksRs();
                rs.AffectedRowCount = await cn.ExecuteAsync(sql, model);
                return rs;
            }
        }

        public async Task<int> CreateWaveAsync(string CampaignCode, string WaveCode, int AvailableMonths = 3)
        {
            var sql = " EXECUTE [dbo].[sp_CreateCampaignWave] @CampaignCode, @WaveCode, @AvailableMonths";
            using (var cn = new SqlConnection(connection))
            {
                var rs = await cn.ExecuteAsync(sql, new { CampaignCode, WaveCode, AvailableMonths });
                return rs;
            }
        }
    }
}
