using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Attributes;

namespace NCB.CSI.Models.BMS.Common {
    [Validator(typeof(GetCodeBooksRqValidator))]
    public class GetCodeBooksRq {
        public string locale { get; set; }
        public string codeType { get; set; }
    }

    public class GetCodeBooksRqValidator : AbstractValidator<GetCodeBooksRq> {
        public GetCodeBooksRqValidator() {
            RuleFor(x => x.locale).NotEmpty();
            RuleFor(x => x.codeType).NotEmpty();
        }
    }

    public class GetCodeBooksRs : BmsCommonRs<IEnumerable<CodeBookItem>> {
    }

    public class CodeBookItem {
        public string code { get; set; }
        public string name { get; set; }
        public IEnumerable<BmsCodeAndName> details { get; set; }
    }
}
