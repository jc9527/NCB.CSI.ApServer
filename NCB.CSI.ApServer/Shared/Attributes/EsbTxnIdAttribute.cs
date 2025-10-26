using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NCB.CSI.ApServer.Shared.Attributes {
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class EsbTxnIdAttribute : Attribute {
        public string TxnId { get; set; }
        public EsbTxnIdAttribute(string txnId) => TxnId = txnId;
    }
}