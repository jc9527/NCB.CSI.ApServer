using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CBS {
    public class CbsCommonRs {
        public CbsHeader header { get; set; }
        public CbsError error { get; set; }
    }

    public class CbsHeader {
        public CbsAudit audit { get; set; }
        public int page_start { get; set; }
        public int total_size { get; set; }
		public int page_size { get; set; }
    }

    public class CbsAudit {
        public int T24_time { get; set; }
        public int responseParse_time { get; set; }
        public int requestParse_time { get; set; }
    }

    public class CbsError {
        public string code { get; set; }
        public string message { get; set; }
        public string type { get; set; }
    }
}
