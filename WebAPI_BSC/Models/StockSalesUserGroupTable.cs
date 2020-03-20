using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockSalesUserGroupTable
    {
        public int StockSalesUserGroupId { get; set; }
        public string StockSalesUserGroupKey { get; set; }
        public string StockSalesUserGroupName { get; set; }
        public bool PosflagSales { get; set; }
        public bool PosflagSalesReturn { get; set; }
        public bool PosflagCash { get; set; }
        public bool PosflagSync { get; set; }
        public bool PosflagSalesQuantityChange { get; set; }
        public bool PosflagSalesCustomerChange { get; set; }
        public bool PosflagSalesTaxMethodChange { get; set; }
        public bool PosflagCashIn { get; set; }
        public bool PosflagCashOut { get; set; }
        public bool PosflagCashX { get; set; }
        public bool PosflagCashZ { get; set; }
    }
}
