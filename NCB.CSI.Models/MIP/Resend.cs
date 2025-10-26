using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.MIP {
    public class ResendRq {
        public string resend_key { get; set; }
        public string mobilephone { get; set; }
        public string cust_id { get; set; }
        public string toemail { get; set; }
    }

    public class ResendRs {
        public string statuscode { get; set; }
        public string statuscodemsg { get; set; }
    }
}
