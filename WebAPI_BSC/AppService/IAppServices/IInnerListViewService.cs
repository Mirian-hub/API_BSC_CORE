using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_BSC.Controllers;

namespace WebAPI_BSC.AppService.IAppServices
{
    public interface IInnerListViewService
    {
        List<InnerListViewModel> GetData(string sourceQuery);
           
    }
}
