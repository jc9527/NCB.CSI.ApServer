using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devpro.Connectors.Net.AbstractServices;
using Devpro.Shared.Attributies;
using NCB.CSI.Models.CSI;

namespace NCB.CSI.ApClient.Services.CSI {
    [ServiceNamespace("Privilege/CSI")]
    public class ImportBmsCase : ApClientBaseService<CampaignTasksRq, CampaignTasksRs> {
        public override Task<(CampaignTasksRs Result, string ResultCode, string ResultMessage)> RunAsync(CampaignTasksRq model) => PostAsync(model);
    }
}
