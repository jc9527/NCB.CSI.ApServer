using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Devpro.Connectors.AbstractServices;
using NCB.CSI.Models.CM;
using NCB.CSI.Models.CSI;

namespace NCB.CSI.ApServer.Services.CSI {
    /// <summary>
    /// 匯入需要作服後續作業的開戶申請件
    /// </summary>
    public class ImportBmsCase : DBService<CampaignTasksRq, CampaignTasksRs> {
        public override async Task<(CampaignTasksRs Result, string ResultCode, string ResultMessage)> RunAsync(CampaignTasksRq model) {
            model.ModifiedBy = "NCB.CSI.Batch";
            model.ModifiedAt = DateTime.Now;
            model.CreatedBy = "NCB.CSI.Batch";
            model.CreatedAt = DateTime.Now;
            var sql = "update CampaignTasks set CustId = @CustId, MobileNo = @MobileNo, JsonData = @JsonData,";
            sql += " Gender = iif(@Gender is null, Gender, @Gender),";
            sql+=  " ChineseName = iif(@ChineseName is null, ChineseName, @ChineseName),";
            sql += " DOB = iif(@DOB is null, DOB, @DOB),";
            sql += " CorrespondenceTelNo = iif(@CorrespondenceTelNo is null, CorrespondenceTelNo, @CorrespondenceTelNo),";
            sql += " Email1 = iif(@Email1 is null, Email1, @Email1),";
            sql += " CorrespondenceAddress = iif(@CorrespondenceAddress is null, CorrespondenceAddress, @CorrespondenceAddress),";
            sql += " Int01 = iif(@Int01 is null, Int01, @Int01), Int02 = iif(@Int02 is null, Int02, @Int02),";
            sql += " Int03 = iif(@Int03 is null, Int03, @Int03), Int04 = iif(@Int04 is null, Int04, @Int04),";
            sql += " Int05 = iif(@Int05 is null, Int05, @Int05), Int06 = iif(@Int06 is null, Int06, @Int06),";
            sql += " Int07 = iif(@Int07 is null, Int07, @Int07), Int08 = iif(@Int08 is null, Int08, @Int08),";
            sql += " Int09 = iif(@Int09 is null, Int09, @Int09), Int10 = iif(@Int10 is null, Int10, @Int10),";
            sql += " Int11 = iif(@Int11 is null, Int11, @Int11), Int12 = iif(@Int12 is null, Int12, @Int12),";
            sql += " Int13 = iif(@Int13 is null, Int13, @Int13), Int14 = iif(@Int14 is null, Int14, @Int14),";
            sql += " Int15 = iif(@Int15 is null, Int15, @Int15), Int16 = iif(@Int16 is null, Int16, @Int16),";
            sql += " Int17 = iif(@Int17 is null, Int17, @Int17), Int18 = iif(@Int18 is null, Int18, @Int18),";
            sql += " Int19 = iif(@Int19 is null, Int19, @Int19), Int20 = iif(@Int20 is null, Int20, @Int20),";
            sql += " Data01 = iif(@Data01 is null, Data01, @Data01), Data02 = iif(@Data02 is null, Data02, @Data02),";
            sql += " Data03 = iif(@Data03 is null, Data03, @Data03), Data04 = iif(@Data04 is null, Data04, @Data04),";
            sql += " Data05 = iif(@Data05 is null, Data05, @Data05), Data06 = iif(@Data06 is null, Data06, @Data06),";
            sql += " Data07 = iif(@Data07 is null, Data07, @Data07), Data08 = iif(@Data08 is null, Data08, @Data08),";
            sql += " Data09 = iif(@Data09 is null, Data09, @Data09), Data10 = iif(@Data10 is null, Data10, @Data10),";
            sql += " Data11 = iif(@Data11 is null, Data11, @Data11), Data12 = iif(@Data12 is null, Data12, @Data12),";
            sql += " Data13 = iif(@Data13 is null, Data13, @Data13), Data14 = iif(@Data14 is null, Data14, @Data14),";
            sql += " Data15 = iif(@Data15 is null, Data15, @Data15), Data16 = iif(@Data16 is null, Data16, @Data16),";
            sql += " Data17 = iif(@Data17 is null, Data17, @Data17), Data18 = iif(@Data18 is null, Data18, @Data18),";
            sql += " Data19 = iif(@Data19 is null, Data19, @Data19), Data20 = iif(@Data20 is null, Data20, @Data20),";
            sql += " Data21 = iif(@Data21 is null, Data21, @Data21), Data22 = iif(@Data22 is null, Data22, @Data22),";
            sql += " Data23 = iif(@Data23 is null, Data23, @Data23), Data24 = iif(@Data24 is null, Data24, @Data24),";
            sql += " Data25 = iif(@Data25 is null, Data25, @Data25), Data26 = iif(@Data26 is null, Data26, @Data26),";
            sql += " Data27 = iif(@Data27 is null, Data27, @Data27), Data28 = iif(@Data28 is null, Data28, @Data28),";
            sql += " Data29 = iif(@Data29 is null, Data29, @Data29), Data30 = iif(@Data30 is null, Data30, @Data30)";
            sql += " where TaskTag1 = @TaskTag1 and CampaignCode = @CampaignCode and CustId = @CustId";
            sql += " if @@ROWCOUNT = 0 begin";
            sql += " insert CampaignTasks(CampaignCode, WaveCode, DepartmentCode, CustId, MobileNo, TaskTag1, JsonData, ChineseName, Gender, DOB, CorrespondenceTelNo,";
            sql += " Email1, CorrespondenceAddress, Int01, Int02, Int03, Int04, Int05, Data01, Data02, Data03, Data04, Data05, Data06, Data07, Data08, Data09, Data10,";
            sql += " Data11, Data12, Data13, Data14, Data15, Data16, Data17, Data18, Data19, Data20, Data21, Data22, Data23, Data24, ModifiedBy, ModifiedAt, CreatedBy, CreatedAt)";
            sql += " values(";
            sql += " isnull(@CampaignCode, ''), isnull(@WaveCode, ''),";
            sql += " isnull(@DepartmentCode, ''), isnull(@CustId, ''),";
            sql += " isnull(@MobileNo, ''), isnull(@TaskTag1, ''),";
            sql += " isnull(@JsonData, ''), isnull(@ChineseName, ''),";
            sql += " @Gender, @DOB, @CorrespondenceTelNo,";
            sql += " @Email1, @CorrespondenceAddress, @Int01, @Int02, @Int03, @Int04, @Int05, @Data01, @Data02, @Data03, @Data04, @Data05, @Data06, @Data07, @Data08, @Data09, @Data10,";
            sql += " @Data11, @Data12, @Data13, @Data14, @Data15, @Data16, @Data17, @Data18, @Data19, @Data20, @Data21, @Data22, @Data23, @Data24, @ModifiedBy, @ModifiedAt, @CreatedBy, @CreatedAt)";
            sql += " end;";
            return SuccessResult(new CampaignTasksRs { AffectedRowCount = await ExecuteAsync("CSIDB", sql, model) });
        }
    }
}