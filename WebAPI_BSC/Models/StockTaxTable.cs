using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockTaxTable
    {
        public StockTaxTable()
        {
            StockCompanyTable = new HashSet<StockCompanyTable>();
            StockItemTable = new HashSet<StockItemTable>();
        }

        public int StockTaxId { get; set; }
        public string StockTaxKey { get; set; }
        public string StockTaxName { get; set; }
        public string StockTaxNote { get; set; }
        public int StockTaxTypeId { get; set; }
        public int StockTaxStatusId { get; set; }
        public double StockTaxFactor { get; set; }
        public double StockTaxBaseFactor { get; set; }

        public virtual StockTaxStatusTable StockTaxStatus { get; set; }
        public virtual StockTaxTypeTable StockTaxType { get; set; }
        public virtual ICollection<StockCompanyTable> StockCompanyTable { get; set; }
        public virtual ICollection<StockItemTable> StockItemTable { get; set; }
    }
}
