using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Deposit {
    [Validator(typeof(PocketListRqValidator))]
    public class PocketListRq {
        /// <summary>
        /// User Cif No
        /// </summary>
        public string cifNo { get; set; }
    }

    public class PocketListRqValidator : AbstractValidator<PocketListRq> {
        public PocketListRqValidator() {
            RuleFor(x => x.cifNo).NotEmpty();
        }
    }

    public class PocketListRs: BmsCommonRs<PocketListData> {
    }

    public class PocketListData {
        /// <summary>
        /// 定存單總額
        /// </summary>
        public decimal termDepositTotalAmount { get; set; }
        /// <summary>
        /// 活存口袋總額
        /// </summary>
        public decimal depositTotalAmount { get; set; }

        public IEnumerable<PocketListRsDetail> pocketDetails { get; set; }
    }

    public class PocketListRsDetail {
        /// <summary>
        /// 單號
        /// </summary>
        public string accNo { get; set; }
        /// <summary>
        /// 合約編號
        /// </summary>
        public string arrngId { get; set; }
        /// <summary>
        /// 口袋Icon
        /// </summary>
        public string depositIcon { get; set; }
        /// <summary>
        /// 開始日
        /// </summary>
        public string openDate { get; set; }
        /// <summary>
        /// 到期日
        /// </summary>
        public string dueDate { get; set; }
        /// <summary>
        /// 現在時間
        /// </summary>
        public string dateNow { get; set; }
        /// <summary>
        /// 口袋名稱
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 口袋金額
        /// </summary>
        public decimal? amount { get; set; }
        /// <summary>
        /// 口袋類型
        /// </summary>
        public string depositType { get; set; }
        /// <summary>
        /// 票券資訊
        /// </summary>
        public PocketListRsDetailCouponDetail couponDetail { get; set; }
    }

    public class PocketListRsDetailCouponDetail {
        /// <summary>
        /// 票券名稱
        /// </summary>
        public string couponName { get; set; }
        /// <summary>
        /// 加息利率
        /// </summary>
        public decimal? interestRate { get; set; }
        /// <summary>
        /// 最低計息金額
        /// </summary>
        public decimal? balanceLowerBound { get; set; }
        /// <summary>
        /// 最高計息金額
        /// </summary>
        public decimal? balanceUpperBound { get; set; }
        /// <summary>
        /// 加息天數
        /// </summary>
        public int? validDays { get; set; }
        /// <summary>
        /// 票券使用日
        /// </summary>
        public string redeemDate { get; set; }
        /// <summary>
        /// 票券過期日
        /// </summary>
        public string dueDate { get; set; }
    }
}
