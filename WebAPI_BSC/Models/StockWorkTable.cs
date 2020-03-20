﻿using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockWorkTable
    {
        public int ShellUserId { get; set; }
        public int ShellOperationId { get; set; }
        public int ShellWorkPageId { get; set; }
        public int ShellWorkPageLineId { get; set; }
        public int? ShellWorkPageParentId { get; set; }
        public string ShellWorkPageLineParentId { get; set; }
        public double ShellWorkPageSign { get; set; }
        public int ShellWorkPageAuto { get; set; }
        public int ShellMessageId { get; set; }
        public int ShellWorkStatusId { get; set; }
        public int ShellComputerId { get; set; }
        public int ShellCreatorUserId { get; set; }
        public DateTime ShellCreationDate { get; set; }
        public int ShellModifierUserId { get; set; }
        public DateTime ShellModificationDate { get; set; }
        public int? StockEntryId { get; set; }
        public int StockEntryId2 { get; set; }
        public long StockEntryLineId { get; set; }
        public string StockEntryKey { get; set; }
        public string StockEntryName { get; set; }
        public DateTime StockEntryDate { get; set; }
        public DateTime StockEntryDate2 { get; set; }
        public int StockEntryTypeId { get; set; }
        public int StockEntryStatusId { get; set; }
        public int StockEntrySortId { get; set; }
        public int StockEntryParentId { get; set; }
        public long StockEntryLineParentId { get; set; }
        public int StockItemId { get; set; }
        public int StockItemId2 { get; set; }
        public int StockLocationId { get; set; }
        public int StockLocationId2 { get; set; }
        public double StockQuantity { get; set; }
        public double StockQuantity2 { get; set; }
        public double StockAmount { get; set; }
        public double StockAmount2 { get; set; }
        public double StockRestQuantity { get; set; }
        public double StockRestQuantity2 { get; set; }
        public double StockRestQuantity3 { get; set; }
        public int StockItemGroupId { get; set; }
        public int StockItemGroupId2 { get; set; }
        public int StockAllocationBaseId { get; set; }
        public int StockCarId { get; set; }
        public int StockPersonId { get; set; }
        public int StockDeliveryId { get; set; }
        public string TextCompanyKey { get; set; }
        public string TextCompanyName { get; set; }
        public string TextCompanyAddress { get; set; }
        public string TextStockCarKey { get; set; }
        public string TextStockCarName { get; set; }
        public string TextStockPersonKey { get; set; }
        public string TextStockPersonName { get; set; }
        public int TransCompanyId { get; set; }
        public int TransTaxMethodId { get; set; }
        public double TransTaxMethodFactor { get; set; }
        public int TransItemId { get; set; }
        public int TransItemUnitId { get; set; }
        public double TransItemUnitFactor { get; set; }
        public double TransItemUnitFactor2 { get; set; }
        public double TransQuantityInitial { get; set; }
        public double TransQuantity { get; set; }
        public int TransQuantityAllowChange { get; set; }
        public double TransPriceInitial { get; set; }
        public double TransPrice { get; set; }
        public int TransPriceAllowChange { get; set; }
        public double TransPriceOverall { get; set; }
        public int TransPriceTaxId { get; set; }
        public double TransPriceTaxFactor { get; set; }
        public double TransAmount { get; set; }
        public double TransTaxAmount { get; set; }
        public double TransBaseAmount { get; set; }
        public int TransDiscountId { get; set; }
        public double TransDiscountFactor { get; set; }
        public double TransDiscountAmount { get; set; }
        public double TransDiscountTaxAmount { get; set; }
        public double TransDiscountBaseAmount { get; set; }
        public int RswaybillTypeId { get; set; }
        public long RswaybillId { get; set; }
        public string RswaybillKey { get; set; }
        public int ShellWorkTrigger { get; set; }
        public int TransItemBomid { get; set; }
        public string TransItemKey { get; set; }
        public string TransItemName { get; set; }
        public string TransItemUnitName { get; set; }
        public string StockItemKey { get; set; }
        public string StockItemName { get; set; }
        public double TransQuantityFactor { get; set; }
        public int StockBomplanLineStatusId { get; set; }
        public string StockItemUnitName { get; set; }
        public int ShellCustomerId { get; set; }
        public int StockBomplanLineTypeId { get; set; }
        public bool StockFlag1 { get; set; }
        public bool StockFlag2 { get; set; }
        public bool StockFlag3 { get; set; }
        public double QuantityW1 { get; set; }
        public double QuantityW2 { get; set; }
        public double QuantityW3 { get; set; }
        public double QuantityW4 { get; set; }
        public double QuantityW5 { get; set; }
        public double QuantityW6 { get; set; }
        public double QuantityW7 { get; set; }
        public double QuantityW0 { get; set; }
        public double LeftDays { get; set; }
        public double MinQuantity { get; set; }
        public double MaxQuantity { get; set; }
        public double MinDays { get; set; }
        public double MaxDays { get; set; }
        public int StockDeliveryGraphId { get; set; }
        public int StockDeliveryTypeId { get; set; }
        public int StockUsageTypeId { get; set; }
        public double StockQlimitFactor { get; set; }
        public double OrderFactor { get; set; }
        public double PackQuantity { get; set; }
        public double StockQuantity3 { get; set; }
        public int TransCompanyGroupId { get; set; }
        public bool StockFlag4 { get; set; }
        public bool StockFlag5 { get; set; }
        public double OrderDays { get; set; }
        public int StockRptypeId { get; set; }
        public double StockRestQuantity4 { get; set; }
        public double StockRestQuantity3New { get; set; }
    }
}
