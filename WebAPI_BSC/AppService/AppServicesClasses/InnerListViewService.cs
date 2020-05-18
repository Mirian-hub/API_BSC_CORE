using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_BSC.AppService.IAppServices;
using WebAPI_BSC.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Xml;
using WebAPI_BSC.Controllers.OperationSpecificModels;
using WebAPI_BSC.Models;
using System.Xml.Linq;
using System.Reflection;
namespace WebAPI_BSC.AppService.AppServicesClasses
{
    public class InnerListViewService: IInnerListViewService
    {
        List<InnerListViewModel> res = new List<InnerListViewModel>(); 
       public List<InnerListViewModel> GetData(string sourceQuery)
        {
            using (var context = new BSCSolution257Context())
            {
                using (var command = context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = sourceQuery;
                    context.Database.OpenConnection();
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            switch(reader.FieldCount)
                            {
                                case 0: res.Add(new InnerListViewModel {
                                    NumberOfColumn = 0
                                }); break;
                                case 1: res.Add(new InnerListViewModel
                                {
                                    Col1 = reader[0].ToString(),
                                    NumberOfColumn =1
                                }); break;
                                case 2:
                                res.Add(new InnerListViewModel
                                {
                                    Col1 = reader[0].ToString(),
                                    Col2 = reader[1].ToString(),
                                    NumberOfColumn = 2
                                }); break;
                                case 3:
                                res.Add(new InnerListViewModel
                                {
                                    Col1 = reader[0].ToString(),
                                    Col2 = reader[1].ToString(),
                                    Col3 = reader[2].ToString(),
                                    NumberOfColumn = 3
                                }); break;
                                case 4:
                                res.Add(new InnerListViewModel
                                {
                                    Col1 = reader[0].ToString(),
                                    Col2 = reader[1].ToString(),
                                    Col3 = reader[2].ToString(),
                                    Col4 = reader[3].ToString(),
                                    NumberOfColumn = 4
                                }); break;
                            }
                        }
                    }
                    //context.Database.CloseConnection();
                }
            }



            return res;
        }
    }
}
