using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockLocationTable
    {
        public StockLocationTable()
        {
            ShellComputerTable = new HashSet<ShellComputerTable>();
            StockEntryLineTable = new HashSet<StockEntryLineTable>();
            StockLocationAddressTable = new HashSet<StockLocationAddressTable>();
            StockLocationItemTable = new HashSet<StockLocationItemTable>();
            StockLocationRightTable = new HashSet<StockLocationRightTable>();
            StockLocationShelfTable = new HashSet<StockLocationShelfTable>();
        }

        public int StockLocationId { get; set; }
        public string StockLocationKey { get; set; }
        public string StockLocationName { get; set; }
        public int StockLocationTypeId { get; set; }
        public int StockLocationStatusId { get; set; }
        public DateTime? StockLocationValidFrom { get; set; }
        public DateTime? StockLocationValidTo { get; set; }
        public int StockLocationGroupId { get; set; }
        public string StockLocationAddress { get; set; }
        public int? PersonId { get; set; }
        public int? PersonId2 { get; set; }
        public int? PersonId3 { get; set; }
        public int? StockCustomerId { get; set; }
        public int? StockLocationId2 { get; set; }
        public string ExactCostCenter { get; set; }
        public string StockPrinterName { get; set; }
        public string StockLocationNameEn { get; set; }
        public int? StockLocationId3 { get; set; }
        public string StockLocationNameRu { get; set; }
        public int? ExactId { get; set; }
        public int StockLocationSortId { get; set; }

        public virtual StockLocationGroupTable StockLocationGroup { get; set; }
        public virtual StockLocationStatusTable StockLocationStatus { get; set; }
        public virtual StockLocationTypeTable StockLocationType { get; set; }
        public virtual ICollection<ShellComputerTable> ShellComputerTable { get; set; }
        public virtual ICollection<StockEntryLineTable> StockEntryLineTable { get; set; }
        public virtual ICollection<StockLocationAddressTable> StockLocationAddressTable { get; set; }
        public virtual ICollection<StockLocationItemTable> StockLocationItemTable { get; set; }
        public virtual ICollection<StockLocationRightTable> StockLocationRightTable { get; set; }
        public virtual ICollection<StockLocationShelfTable> StockLocationShelfTable { get; set; }
    }
}
