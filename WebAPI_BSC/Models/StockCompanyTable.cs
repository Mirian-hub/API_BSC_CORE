using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockCompanyTable
    {
        public StockCompanyTable()
        {
            StockEntryTableShellCustomer = new HashSet<StockEntryTable>();
            StockEntryTableTransCompany = new HashSet<StockEntryTable>();
            StockLocationAddressTable = new HashSet<StockLocationAddressTable>();
            StockSalesItemGroupNameTable = new HashSet<StockSalesItemGroupNameTable>();
        }

        public int StockCompanyId { get; set; }
        public string StockCompanyKey { get; set; }
        public string StockCompanyName { get; set; }
        public string StockCompanyNote { get; set; }
        public int StockCompanySortId { get; set; }
        public int StockCompanyTypeId { get; set; }
        public int StockCompanyStatusId { get; set; }
        public int StockCompanyGroupId { get; set; }
        public int StockPriceId { get; set; }
        public int StockTaxId { get; set; }
        public int StockTaxMethodId { get; set; }
        public double StockCompanyDiscountFactor { get; set; }
        public string StockCompanyAddress { get; set; }
        public string StockCompanyAddress2 { get; set; }
        public string StockCompanyAddress3 { get; set; }
        public string StockCompanyPhone { get; set; }
        public string StockCompanyFax { get; set; }
        public string StockCompanyMail { get; set; }
        public string StockCompanyWeb { get; set; }
        public string StockCompanyCountry { get; set; }
        public string StockCompanyTaxNumber { get; set; }
        public string StockCompanyBankCode { get; set; }
        public string StockCompanyBankName { get; set; }
        public string StockCompanyBankAccount { get; set; }
        public int StockCompanyParentId { get; set; }
        public int StockCompanyFlag { get; set; }
        public int StockPlanningMethodId { get; set; }

        public virtual StockCompanyGroupTable StockCompanyGroup { get; set; }
        public virtual StockCompanyStatusTable StockCompanyStatus { get; set; }
        public virtual StockCompanyTypeTable StockCompanyType { get; set; }
        public virtual StockPriceTable StockPrice { get; set; }
        public virtual StockTaxTable StockTax { get; set; }
        public virtual ICollection<StockEntryTable> StockEntryTableShellCustomer { get; set; }
        public virtual ICollection<StockEntryTable> StockEntryTableTransCompany { get; set; }
        public virtual ICollection<StockLocationAddressTable> StockLocationAddressTable { get; set; }
        public virtual ICollection<StockSalesItemGroupNameTable> StockSalesItemGroupNameTable { get; set; }
    }
}
