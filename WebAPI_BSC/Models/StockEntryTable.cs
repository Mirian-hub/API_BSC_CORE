using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockEntryTable
    {
        public StockEntryTable()
        {
            StockEntryLineTable = new HashSet<StockEntryLineTable>();
            StockPriceLineTable = new HashSet<StockPriceLineTable>();
        }

        public int StockEntryId { get; set; }
        public int StockEntryId2 { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public int StockEntryParentId { get; set; }
        public int StockEntryParentId2 { get; set; }
        public int StockEntryTypeId { get; set; }
        public int StockEntryStatusId { get; set; }
        public int StockEntrySortId { get; set; }
        public DateTime StockEntryDate { get; set; }
        public DateTime StockEntryDate2 { get; set; }
        public int StockItemGroupId { get; set; }
        public int StockItemGroupId2 { get; set; }
        public int StockLocationId { get; set; }
        public int StockLocationId2 { get; set; }
        public int StockPersonId { get; set; }
        public int StockCarId { get; set; }
        public int StockDeliveryId { get; set; }
        public int StockAllocationBaseId { get; set; }
        public int StockPayPeriodId { get; set; }
        public string TextCompanyKey { get; set; }
        public string TextCompanyName { get; set; }
        public string TextCompanyAddress { get; set; }
        public string TextStockPersonKey { get; set; }
        public string TextStockPersonName { get; set; }
        public string TextStockCarKey { get; set; }
        public string TextStockCarName { get; set; }
        public long RswaybillId { get; set; }
        public string RswaybillKey { get; set; }
        public long RswaybillParentId { get; set; }
        public string RswaybillParentKey { get; set; }
        public int RswaybillConfirmId { get; set; }
        public int RsmessageId { get; set; }
        public int RsmessageCounterId { get; set; }
        public int RssyncProcessId { get; set; }
        public DateTime RssyncDate { get; set; }
        public int ShellUserId { get; set; }
        public int ShellComputerId { get; set; }
        public int ShellCustomerId { get; set; }
        public DateTime ShellCreationDate { get; set; }
        public int ShellCreatorUserId { get; set; }
        public DateTime ShellModificationDate { get; set; }
        public int ShellModifierUserId { get; set; }
        public int ShellSyncProcessId { get; set; }
        public DateTime ShellSyncDate { get; set; }
        public int TransCompanyId { get; set; }
        public int TransCompanyId2 { get; set; }
        public int TransCompanyCardId { get; set; }
        public int TransTaxMethodId { get; set; }
        public double TransTaxMethodFactor { get; set; }
        public int TransPayMethodId { get; set; }
        public double TransAmount { get; set; }
        public double TransTaxAmount { get; set; }
        public double TransBaseAmount { get; set; }
        public int TransServiceId { get; set; }
        public double TransServiceFactor { get; set; }
        public double TransServiceAmount { get; set; }
        public double TransServiceTaxAmount { get; set; }
        public double TransServiceBaseAmount { get; set; }
        public int TransDiscountId { get; set; }
        public double TransDiscountFactor { get; set; }
        public double TransDiscountAmount { get; set; }
        public double TransDiscountTaxAmount { get; set; }
        public double TransDiscountBaseAmount { get; set; }
        public double TransTotalAmount { get; set; }
        public double TransTotalTaxAmount { get; set; }
        public double TransTotalBaseAmount { get; set; }
        public double TransTotalPayAmount { get; set; }
        public double TransPayCashAmount { get; set; }
        public double TransPayCashChangeAmount { get; set; }
        public double TransPayBankAmount { get; set; }
        public double TransPayInvoiceAmount { get; set; }
        public double TransPayOtherAmount { get; set; }
        public double TransQuantity { get; set; }
        public double TransLocationShelfId { get; set; }
        public int RswaybillTypeId { get; set; }

        public virtual StockCompanyTable ShellCustomer { get; set; }
        public virtual ShellUserTable ShellUser { get; set; }
        public virtual StockCarTable StockCar { get; set; }
        public virtual StockEntryStatusTable StockEntryStatus { get; set; }
        public virtual StockEntryTypeTable StockEntryType { get; set; }
        public virtual StockPersonTable StockPerson { get; set; }
        public virtual StockCompanyTable TransCompany { get; set; }
        public virtual ICollection<StockEntryLineTable> StockEntryLineTable { get; set; }
        public virtual ICollection<StockPriceLineTable> StockPriceLineTable { get; set; }
    }
}
