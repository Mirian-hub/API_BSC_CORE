using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_BSC.ClientModels;

namespace WebAPI_BSC.Controllers
{
    public class MainModel
    {
        public string col1 { get; set; }
        public string col2 { get; set; }
        public string col3 { get; set; }
        public string col4 { get; set; }
        public string col5 { get; set; }
        public string col6 { get; set; }
        public string col7 { get; set; }
        public string col8 { get; set; }
        public string col9 { get; set; }
        public string col10 { get; set; }
        public string col11 { get; set; }
        public string col12 { get; set; }
        public string col13 { get; set; }
        public string col14 { get; set; }
        public string col15 { get; set; }
        public string col16 { get; set; }
        public string col17 { get; set; }
        public string col18 { get; set; }
        public string col19 { get; set; }
        public string col20 { get; set; }
        public string GroupKey { get; set; }
        public string GroupName { get; set; }
        public List<string> colNames { get; set; }
        public int operationId { get; set; } 
        public List<string> EditPagesSource { get; set; }
        public string ShellPageKey { get; set; }
        public string ExecutedQuery { get; set; }
        public List<string> DefaultColNames { get; set; }
        public List<ChildTemplateModel> ChildTemplates { get; set; }
        public List<bool> ColumnIsEditable { get; set; }
        public List<string> ColTemplateTypes { get; set; }
        public List<bool> colIsSimple { get; set; }
    }
}
