using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebAPI_BSC.Controllers;

namespace WebAPI_BSC.AppService.IAppServices
{
    public interface IMain
    {
        List<MainModel> GetListViewData(int? operationsId, string sourceName, List<GroupModel> groupingModel, XDocument doc, int selectedRowId, string shellPageKey, int pageNumber);
    }
}
