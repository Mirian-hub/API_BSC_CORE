using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_BSC.ClientModels
{
    public class DropDownModel
    { 
        public ManuVModel FirstLevel { get; set; }
        public List<ManuVModel> SecondLevel { get; set; }
        public Dictionary<int, Dictionary<int, List<ManuVModel>>> ThirdLevel { get; set; }
        public List<GroupingModel> LeftGroupModelList { get; set; }
        public List<ListViewModel> ListView { get; set; }
        public string PageTitle { get; set; }
        public List<string> TypeSource { get; set; }
        public List<string> StatusSource { get; set; }
        public List<PageSearhcModel> PageSearchSource { get; set; }
        public List<PageSortModel> PaegSortSource { get; set; }
    }
    public class GroupingModel
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
    public class ListViewModel
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
        public int col12 { get; set; }
        public List<string> ColumnNamesENG { get; set; }
        public List<string> ColumnNemesGE { get; set; }

    }

    public class PageSearhcModel
    {
        public string SearchName { get; set; }
        public string SearchFormat { get; set; }
    }
    public class PageSortModel
    {
        public string SortName { get; set; }
        public string SortFormat { get; set; }
    }

    
    public class ManuModel
    {
        List<ManuHelperModel> MHModel { set; get; } 
    }
    public class ManuHelperModel
    {
     public List<ManuVModel> FirstLevel { get; set; }
     public List<ManuVModel> SecondLevel { get; set; }
     public List<ManuVModel> ThirdLevel { get; set; }
    }
    
}
