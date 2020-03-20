using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockItemTable
    {
        public StockItemTable()
        {
            StockBomplanLineTable = new HashSet<StockBomplanLineTable>();
            StockBomplanTable = new HashSet<StockBomplanTable>();
            StockEntryLineTable = new HashSet<StockEntryLineTable>();
            StockItemBarcodeTable = new HashSet<StockItemBarcodeTable>();
            StockLocationItemTable = new HashSet<StockLocationItemTable>();
        }

        public int StockItemId { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public string StockItemNote { get; set; }
        public int StockItemSortId { get; set; }
        public int StockItemTypeId { get; set; }
        public int StockItemGroupId { get; set; }
        public int StockItemStatusId { get; set; }
        public int StockItemUnitId { get; set; }
        public int StockTaxId { get; set; }
        public int StockItemValidDays { get; set; }
        public int StockItemId2 { get; set; }
        public double StockQuantity2 { get; set; }
        public double StockQuantity3 { get; set; }
        public double StockItemNweight { get; set; }
        public double StockItemGweight { get; set; }
        public double StockItemProtein { get; set; }
        public double StockItemFat { get; set; }
        public double StockItemCarbohydrate { get; set; }
        public double StockItemCalorie { get; set; }
        public int StockMarkupGroupId { get; set; }
        public string StockItemBarcodeKey { get; set; }
        public double StockItemValidHours { get; set; }
        public string StockItemNote2 { get; set; }

        public virtual StockItemGroupTable StockItemGroup { get; set; }
        public virtual StockItemStatusTable StockItemStatus { get; set; }
        public virtual StockItemTypeTable StockItemType { get; set; }
        public virtual StockItemUnitTable StockItemUnit { get; set; }
        public virtual StockMarkupGroupTable StockMarkupGroup { get; set; }
        public virtual StockTaxTable StockTax { get; set; }
        public virtual ICollection<StockBomplanLineTable> StockBomplanLineTable { get; set; }
        public virtual ICollection<StockBomplanTable> StockBomplanTable { get; set; }
        public virtual ICollection<StockEntryLineTable> StockEntryLineTable { get; set; }
        public virtual ICollection<StockItemBarcodeTable> StockItemBarcodeTable { get; set; }
        public virtual ICollection<StockLocationItemTable> StockLocationItemTable { get; set; }
    }
}
