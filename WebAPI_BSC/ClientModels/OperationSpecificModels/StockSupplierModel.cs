using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_BSC.ClientModels.OperationSpecificModels
{
    public class StockSupplierModel
    {
       public int StockSupplierID { get; set; }
       public string StockSupplierKey { get; set; }
       public string StockSupplierName { get; set; }
       public string StockSupplierTaxNumber { get; set; }
       public int StockTaxID_C { get; set; }
        public string StockSupplierAddress { get; set; }
        public string StockSupplierAddress2 { get; set; }
        public string StockSupplierAddress3 { get; set; }
        public string StockSupplierPhone { get; set; }
        public string StockSupplierMail { get; set; }
        public int StockCompanyTypeID { get; set; }
        public int StockSupplierTypeID { get; set; }
        public int StockSupplierGroupID { get; set; }
    }
}
