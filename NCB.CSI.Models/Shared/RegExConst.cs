using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.Shared {
    public static class RegExConst {
        public static string TwNid => @"^[A-Z][1,2,8,9][0-9]{8}$";
        public static string YYYYMMDD => @"^[12]\d{3}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])$";
        public static string YYYYMMDDHHNNSS => @"^[12]\d{3}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])(([0-1][0-9])|(2[0-3]))[0-5][0-9][0-5][0-9]$";
        public static string YYYY_MM_DD => @"^[12]\d{3}-(0[1-9]|1[0-2])-(0[1-9]|[12]\d|3[01])$";
        public static string MMDD => @"(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])$";
        public static string YYYYMM => @"^[12]\d{3}(0[1-9]|1[0-2])$";
        public static string YYYYslashMMslashDD => @"^[12]\d{3}\/(0[1-9]|1[0-2])\/(0[1-9]|[12]\d|3[01])$";
        /// <summary>
        /// yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        public static string iso8601 => @"^(19|20)\d\d-(0[1-9]|1[012])-([012]\d|3[01])T([01]\d|2[0-3]):([0-5]\d):([0-5]\d)Z$";
        public static string HHNNSS = @"^(([0-1][0-9])|(2[0-3]))[0-5][0-9][0-5][0-9]$";
    }
}
