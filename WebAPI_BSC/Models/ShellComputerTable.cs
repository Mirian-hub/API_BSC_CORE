using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class ShellComputerTable
    {
        public ShellComputerTable()
        {
            ShellComputerUserTable = new HashSet<ShellComputerUserTable>();
        }

        public int ShellComputerId { get; set; }
        public string ShellComputerKey { get; set; }
        public string ShellComputerName { get; set; }
        public int ShellComputerTypeId { get; set; }
        public int ShellComputerStatusId { get; set; }
        public int ShellComputerGroupId { get; set; }
        public int ShellComputerSortId { get; set; }
        public int StockLocationId { get; set; }

        public virtual ShellComputerGroupTable ShellComputerGroup { get; set; }
        public virtual ShellComputerStatusTable ShellComputerStatus { get; set; }
        public virtual ShellComputerTypeTable ShellComputerType { get; set; }
        public virtual StockLocationTable StockLocation { get; set; }
        public virtual ICollection<ShellComputerUserTable> ShellComputerUserTable { get; set; }
    }
}
