using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.CM {
    public class CmCommonRs {
        public int Code { get; set; }
        public string Describe { get; set; }
        public bool Success => Code == 0;
    }
}
