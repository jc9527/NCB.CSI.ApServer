using Devpro.Shared.Attributies;
using FluentValidation;
using FluentValidation.Attributes;
using NCB.CSI.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCB.CSI.Models.BMS.Loan {
    public class GetLoanInfoRq {
    }

    [Validator(typeof(GetLoanInfoByIdRqValidator))]
    public class GetLoanInfoByIdRq {
        [LogItem("CustId")]
        public string idno { get; set; }
    }

    public class GetLoanInfoByIdRqValidator : AbstractValidator<GetLoanInfoByIdRq> {
        public GetLoanInfoByIdRqValidator() {
            RuleFor(x => x.idno).NotEmpty().Matches(RegExConst.TwNid);
        }
    }

    public class GetLoanInfoRs : BmsCommonRs<IEnumerable<GetLoanInfoData>> {
    }

    public class GetLoanInfoData {
        public string caseNumber { get; set; }
        public string productType { get; set; }
        public string loanType { get; set; }
        public int? loanPurpose { get; set; }
        public string loanPurposeOther { get; set; }
        public string drafCaseSource { get; set; }
        public string drafCaseNumber { get; set; }
        public string drafDate { get; set; }
        public int? flow { get; set; }
        public int? status { get; set; }
        public int? loanContract { get; set; }
        public int? personalProtection { get; set; }
        public decimal? loanAmount { get; set; }
        public string currencyType { get; set; }
        public int? loanPeriod { get; set; }
        public bool? isPreRepayment { get; set; }
        public string pid { get; set; }
        public bool? isSanctions { get; set; }
        public bool? isPassZ21 { get; set; }
        public string eddType { get; set; }
        public string aMLScore { get; set; }
        public bool? isToEloan { get; set; }
        public string eloanCaseNumber { get; set; }
        public string rejectDate { get; set; }
        public string modifierId { get; set; }
        public string updatedDate { get; set; }
        public string sendEloanDate { get; set; }
        public IEnumerable<FinancialStatement> financialStatements { get; set; }
        public IEnumerable<AssociatedPerson> associatedPersons { get; set; }
        public IEnumerable<BmsDocumentResend> documentResends { get; set; }
    }

    public class FinancialStatement {
        public string fileId { get; set; }
        public string financialType { get; set; }
        public string fileName { get; set; }
        public string fileExtension { get; set; }
        public string caseNumber { get; set; }
        public bool? isDelete { get; set; }
        public string modifierId { get; set; }
        public string updatedDate { get; set; }
        public string creator { get; set; }
        public string createDate { get; set; }
        public int? uploadFlow { get; set; }
        public string imageId { get; set; }
    }

    public class AssociatedPerson {
        public string caseNumber { get; set; }
        public string pid { get; set; }
        public int? associatedType { get; set; }
        public string borrowerName { get; set; }
        public string cellPhone { get; set; }
        public string email { get; set; }
        public string education { get; set; }
        public string marriage { get; set; }
        public int? child { get; set; }
        public string city { get; set; }
        public string town { get; set; }
        public string addressType { get; set; }
        public string address { get; set; }
        public string resideDate { get; set; }
        public string companyName { get; set; }
        public string industryCodeId { get; set; }
        public string jobTitleCodeId { get; set; }
        public string seniority { get; set; }
        public decimal? salary { get; set; }
        public string companyDept { get; set; }
        public string compyPhone { get; set; }
        public string contactPhone { get; set; }
        public string companyAreaCode { get; set; }
        public string companyPhoneExtension { get; set; }
        public string houseCity { get; set; }
        public string houseTown { get; set; }
        public string houseAddress { get; set; }
    }
}
