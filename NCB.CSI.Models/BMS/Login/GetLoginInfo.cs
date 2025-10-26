using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Login {
    [Validator(typeof(GetLoginInfoRqValidator))]
    public class GetLoginInfoRq {
        [LogItem("CustId")]
        public string idno { get; set; }
    }

    public class GetLoginInfoRqValidator : AbstractValidator<GetLoginInfoRq> {
        public GetLoginInfoRqValidator() {
            RuleFor(x => x.idno).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class GetLoginInfoRs : BmsCommonRs<GetLoginInfoData> {
    }

    public class GetLoginInfoData {
        public IEnumerable<DeviceBinding> deviceBinding { get; set; }
        public IEnumerable<LoginRecord> loginRecord { get; set; }
        public int? todayLoginRemainsCount { get; set; }
        public string loginLastWrongPassTime { get; set; }
    }


    public class DeviceBinding {
        public string addressBookCount { get; set; }
        public string bindType { get; set; }
        public string brand { get; set; }
        public string countryCode { get; set; }
        public string deviceModel { get; set; }
        public string deviceName { get; set; }
        public string deviceSerialNumber { get; set; }
        public string deviceType { get; set; }
        public string deviceUuid { get; set; }
        public string idGateId { get; set; }
        public string manufacturer { get; set; }
        public string memberSeqNo { get; set; }
        public string networkCode { get; set; }
        public string networkType { get; set; }
        public string osVersion { get; set; }
        public string productName { get; set; }
        public string status { get; set; }
        public string telecomName { get; set; }
        public string createDate { get; set; }
        public string createTime { get; set; }
        public string updateDate { get; set; }
        public string updateTime { get; set; }
    }

    public class LoginRecord {
        public string memberSeqNo { get; set; }
        public string idno { get; set; }
        public string phoneNumber { get; set; }
        public string userId { get; set; }
        public string updateDate { get; set; }
        public string updateTime { get; set; }
        public string ip { get; set; }
        public string idGateID { get; set; }
        public string status { get; set; }
        public string lockDate { get; set; }
        public string lockTime { get; set; }
    }
}
