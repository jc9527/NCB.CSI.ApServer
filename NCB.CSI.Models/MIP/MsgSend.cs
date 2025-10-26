using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.MIP {
    public class MsgSendRq {
        public string source { get; set; }
        public string send_date { get; set; }
        public IEnumerable<MsgSendData> data { get; set; }
    }

    public class MsgSendData {
        public string sender { get; set; }
        public string project_category_code { get; set; }
        public string email { get; set; }
        public string sms { get; set; }
        public string push { get; set; }
        public string name { get; set; }
        public string toemail { get; set; }
        public string mobilephone { get; set; }
        public string cust_id { get; set; }
        public string broadcast { get; set; }
        public string email_content { get; set; }
        public string sms_content { get; set; }
        public IDictionary<string, string> para { get; set; }
        public IEnumerable<MsgSendPushOption> push_option { get; set; }
    }

    public class MsgSendPushOption {
        public IDictionary<string, string> param { get; set; }
        public string broadcast { get; set; }
        public string content_type { get; set; }
        public string content { get; set; }
    }

    public class MsgSendRs {
        public string result { get; set; }
        public string result_msg { get; set; }
    }
}
