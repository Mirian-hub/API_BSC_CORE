using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_BSC.Controllers
{
    public class InnerListViewModel
    {
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public int NumberOfColumn { get; set; }
        public List<string> ColumnTemlateTypes { get; set; }
        public List<bool> IsEditableList { get; set; }
        public List<string> ColumnNames { get; set; }
    }
}
