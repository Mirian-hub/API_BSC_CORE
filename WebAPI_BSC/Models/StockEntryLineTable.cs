using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockEntryLineTable
    {
        public long StockEntryLineId { get; set; }
        public long StockEntryLineId2 { get; set; }
        public int StockEntryId { get; set; }
        public int StockEntryId2 { get; set; }
        public int StockEntryLineSortId { get; set; }
        public int StockEntryLineTypeId { get; set; }
        public int StockEntryLineStatusId { get; set; }
        public long StockEntryLineParentId { get; set; }
        public long StockEntryLineParentId2 { get; set; }
        public int StockLocationId { get; set; }
        public int StockLocationId2 { get; set; }
        public int StockItemId { get; set; }
        public int StockItemId2 { get; set; }
        public double StockQuantity { get; set; }
        public double StockAmount { get; set; }
        public DateTime StockEntryLineDate { get; set; }
        public DateTime StockEntryLineDate2 { get; set; }
        public string StockEntryLineKey { get; set; }
        public string StockEntryLineName { get; set; }
        public int ShellSyncProcessId { get; set; }
        public DateTime ShellSyncDate { get; set; }
        public long RsentryId { get; set; }
        public long RsentryLineId { get; set; }
        public long RsentryParentId { get; set; }
        public long RsentryLineParentId { get; set; }
        public int TransItemId { get; set; }
        public int TransItemUnitId { get; set; }
        public double TransItemUnitFactor { get; set; }
        public double TransQuantityInitial { get; set; }
        public double TransQuantity { get; set; }
        public int TransQuantityAllowChange { get; set; }
        public double TransQuantityFactor { get; set; }
        public double TransPriceInitial { get; set; }
        public double TransPrice { get; set; }
        public int TransPriceAllowChange { get; set; }
        public double TransPriceOverall { get; set; }
        public int TransPriceTaxId { get; set; }
        public double TransPriceTaxFactor { get; set; }
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
        public int TransPayPeriodId { get; set; }
        public int TransPayMethodId { get; set; }
        public double TransPayAmount { get; set; }
        public double TransPayChangeAmount { get; set; }
        public int TransItemBomid { get; set; }
        public string TransItemKey { get; set; }
        public int StockBomplanLineStatusId { get; set; }
        public int StockBomplanLineTypeId { get; set; }
        public bool StockFlag1 { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public string StockItemUnitName { get; set; }
        public string TransItemName { get; set; }
        public string TransItemUnitName { get; set; }
        public bool StockFlag2 { get; set; }
        public bool StockFlag3 { get; set; }

        public virtual StockEntryTable StockEntry { get; set; }
        public virtual StockEntryLineStatusTable StockEntryLineStatus { get; set; }
        public virtual StockEntryLineTypeTable StockEntryLineType { get; set; }
        public virtual StockItemTable StockItem { get; set; }
        public virtual StockLocationTable StockLocation { get; set; }
    }
}
