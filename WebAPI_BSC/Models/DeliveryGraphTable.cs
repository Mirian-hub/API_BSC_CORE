using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class DeliveryGraphTable
    {
        public int DeliveryGraphId { get; set; }
        public string DeliveryGraphKey { get; set; }
        public string DeliveryGraphName { get; set; }
        public bool D1 { get; set; }
        public bool D2 { get; set; }
        public bool D3 { get; set; }
        public bool D4 { get; set; }
        public bool D5 { get; set; }
        public bool D6 { get; set; }
        public bool D7 { get; set; }
        public int DeliveryGraphTypeId { get; set; }
    }
}
