using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.ESB.Payment {
    [Validator(typeof(UnlockAddRqValidator))]
    public class UnlockAddRq : EsbRqServiceBody {
        public string UserName { get; set; }
        [LogItem("AccountNo")]
        public string CardNo { get; set; }
        public string TxnDate { get; set; }
        public string TxnTime { get; set; }
        public string AuthKey { get; set; }
        public string TxnAmt { get; set; }
        public string LockSeqNo { get; set; }
        public string UpdtUserId { get; set; }
        public string SprvsrlId { get; set; }
    }

    public class UnlockAddRqValidator : AbstractValidator<UnlockAddRq> {
        public UnlockAddRqValidator() {
            RuleFor(x => x.CardNo).NotEmpty();
            RuleFor(x => x.TxnDate).NotEmpty();
            RuleFor(x => x.AuthKey).NotEmpty();
            RuleFor(x => x.TxnAmt).NotEmpty();
            RuleFor(x => x.LockSeqNo).NotEmpty();
            RuleFor(x => x.UpdtUserId).NotEmpty();
            RuleFor(x => x.SprvsrlId).NotEmpty();
        }
    }

    public class UnlockAddRs : EsbNonT24CommonRs {
    }
}
