using Devpro.Shared.Attributies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.MIP {
    public class QueryResultRq {
        public string mobilephone { get; set; }
        [LogItem("CustId")]
        public string cust_id { get; set; }
        public string toemail { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }

    public class QueryResultRs {
        public string status { get; set; }
        public string result_msg { get; set; }
        public IEnumerable<QueryResultDetail> sms_result { get; set; }
        public IEnumerable<QueryResultDetail> email_result { get; set; }
        public IEnumerable<QueryResultDetail> push_result { get; set; }
    }

    public class QueryResultDetail {
        public string sender { get; set; }
        public string name { get; set; }
        public string mobilephone { get; set; }
        public string cust_id { get; set; }
        public string email { get; set; }
        public string system { get; set; }
        public string source { get; set; }
        public string project_category_code { get; set; }
        public string project_category_name { get; set; }
        public string content { get; set; }
        public string resend_count { get; set; }
        public string send_type { get; set; }
        public string pdf_url { get; set; }
        public string title { get; set; }
        public string message { get; set; }
        public string statuscode { get; set; }
        public string statuscodemsg { get; set; }
        public string send_date { get; set; }
        public string resend_key { get; set; }
        public string bill_date { get; set; }
    }
}
