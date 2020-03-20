using System;
using System.Collections.Generic;

namespace WebAPI_BSC.Models
{
    public partial class StockScaleTable
    {
        public int StockScaleId { get; set; }
        public string StockScaleKey { get; set; }
        public string StockScaleName { get; set; }
        public string StockScaleNote { get; set; }
        public int StockScaleTypeId { get; set; }
        public int StockScaleStatusId { get; set; }
        public double StockScaleFactor { get; set; }
    }
}
