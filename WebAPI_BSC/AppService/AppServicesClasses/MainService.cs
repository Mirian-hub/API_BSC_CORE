using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Xml;
using WebAPI_BSC.ClientModels;
using WebAPI_BSC.ClientModels.OperationSpecificModels;
using WebAPI_BSC.AppService.IAppServices;
using WebAPI_BSC.Models;
using System.Xml.Linq;

namespace WebAPI_BSC.AppService.AppServicesClasses
{
    public class MainService : IMain
    {
        public List<MainModel> GetListViewData(int? operationsId, string sourceName, List<GroupModel> groupingModel, XDocument doc)
        {
            List<string> colNamesFinal = new List<string> ();
            List<string> colNames = new List<string> ();
            List<string> conNamesTranslation = new List<string>();
            List<MainModel> result = new List<MainModel>();

            using (var context = new BSCSolution257Context())
            {
                using (var command = context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = $"SELECT * From {sourceName}";
                    context.Database.OpenConnection();
                    using (var reader = command.ExecuteReader())
                    {
                        int counter = 0;
                        while (reader.Read())
                        {

                                if (counter==0)
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    colNames.Add(reader.GetName(i));
                                }
                            }
                           
                             switch(reader.FieldCount)
                                {
                                    case 0: result = null;
                                            break;
                                    case 1: 
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            GroupKey = groupingModel.Where(c => c.ID.ToString() == reader["ShellTermGroupID"].ToString()).Select(c => c.KEY).FirstOrDefault()
                                        });
                                        
                                        break;
                                    case 2:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            GroupKey = groupingModel.Where(c => c.ID.ToString() == reader["ShellTermGroupID"].ToString()).Select(c => c.KEY).FirstOrDefault()
                                        });
                                        break;
                                    case 3:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                        });
                                        break;
                                    case 4:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                        });
                                        break;
                                    case 5:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString()
                                        }); ;
                                        break;
                                    case 6:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString()
                                        }); ;
                                        break;
                                     case 7:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString()
                                        }); ;
                                        break;
                                    case 8:
                                    result.Add(new MainModel
                                    {
                                        col1 = reader[0].ToString(),
                                        col2 = reader[1].ToString(),
                                        col3 = reader[2].ToString(),
                                        col4 = reader[3].ToString(),
                                        col5 = reader[4].ToString(),
                                        col6 = reader[5].ToString(),
                                        col7 = reader[6].ToString(),
                                        col8 = reader[7].ToString(),
                                        GroupKey = groupingModel.Where(c => c.ID.ToString() == reader["ShellTermGroupID"].ToString()).Select(c => c.KEY).FirstOrDefault(),
                                        GroupName = groupingModel.Where(c => c.ID.ToString() == reader["ShellTermGroupID"].ToString()).Select(c => c.NAME).FirstOrDefault()
                                        }); ;
                                        break;
                                    case 9:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString(),
                                            col8 = reader[7].ToString(),
                                            col9 = reader[8].ToString(),
                                        }); ;
                                        break;
                                    case 10:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString(),
                                            col8 = reader[7].ToString(),
                                            col9 = reader[8].ToString(),
                                            col10 = reader[9].ToString(),

                                        }); ;
                                        break;
                                    case 11:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString(),
                                            col8 = reader[7].ToString(),
                                            col9 = reader[8].ToString(),
                                            col10 = reader[9].ToString(),
                                            col11 = reader[10].ToString(),

                                        }); ;
                                        break;
                                    case 12:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString(),
                                            col8 = reader[7].ToString(),
                                            col9 = reader[8].ToString(),
                                            col10 = reader[9].ToString(),
                                            col11 = reader[10].ToString(),
                                            col12 = reader[11].ToString(),

                                        }); ;
                                        break;
                                    case 13:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString(),
                                            col8 = reader[7].ToString(),
                                            col9 = reader[8].ToString(),
                                            col10 = reader[9].ToString(),
                                            col11 = reader[10].ToString(),
                                            col12 = reader[11].ToString(),
                                            col13 = reader[12].ToString(),

                                        }); ;
                                        break;
                                    case 14:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString(),
                                            col8 = reader[7].ToString(),
                                            col9 = reader[8].ToString(),
                                            col10 = reader[9].ToString(),
                                            col11 = reader[10].ToString(),
                                            col12 = reader[11].ToString(),
                                            col13 = reader[12].ToString(),
                                            col14 = reader[13].ToString(),

                                        }); ;
                                        break;
                                    case 15:
                                        result.Add(new MainModel
                                        {
                                            col1 = reader[0].ToString(),
                                            col2 = reader[1].ToString(),
                                            col3 = reader[2].ToString(),
                                            col4 = reader[3].ToString(),
                                            col5 = reader[4].ToString(),
                                            col6 = reader[5].ToString(),
                                            col7 = reader[6].ToString(),
                                            col8 = reader[7].ToString(),
                                            col9 = reader[8].ToString(),
                                            col10 = reader[9].ToString(),
                                            col11 = reader[10].ToString(),
                                            col12 = reader[11].ToString(),
                                            col13 = reader[12].ToString(),
                                            col14 = reader[13].ToString(),
                                            col15 = reader[14].ToString(),

                                        }); ;
                                        break;
                            }
                            counter++;
                        }
                    }
                }
                result.First().operationId = operationsId ?? default(int);

                foreach (var item in colNames)  
                {
                    var targetNode = doc.Element("ShellData").Element("ShellControlList").Elements("ShellControl").Where(e => e.Element("ShellControlKey").Value == item).FirstOrDefault();
                    if (targetNode != null)
                        conNamesTranslation.Add(targetNode.Element("ShellControlName").Value);
                    else
                        conNamesTranslation.Add("empty");
                }
                var pdasdas = conNamesTranslation.Distinct().ToList();
                result.First().colNames = conNamesTranslation.ToList();
            }

            //using (var context = new BSCSolution257Context())
            //{
            //    using (var command = context.Database.GetDbConnection().CreateCommand())
            //    {
            //        // პარამეტრის გადაცემა შესაცვლელია 
            //        command.Command<ShellControl>Text = $"SELECT top 1500 * From {sourceName}";
            //        context.Database.OpenConnection();
            //        using (var reader = command.ExecuteReader())
            //        {
            //            int counter = 0;
            //            while (reader.Read())
            //            {
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    if (res == null)
            //                    {
            //                        rowNames += reader.GetName(i) + ";";
            //                    }
            //                }
            //            if (res == null)
            //                res += "[{";
            //                for (int i = 0; i < reader.FieldCount; i++)
            //                {
            //                    res += reader[i].ToString() + ";";
            //                }
            //                res += groupingModel[counter].KEY + ";";
            //                res += groupingModel[counter].NAME + ";";
            //            }
            //        filedCount = reader.FieldCount;
            //    }
            //  }
            //}             
            //res +="|||"+ rowNames + "||| columnNum: " + filedCount + "}]";

            //using (var _context = new BSCSolution257Context())
            //{
            //    var tmp = _context.Database.ExecuteSqlCommand("SELECT * From StockSupplierGroupEdit1").ToString();

            //    //foreach (var item in tmp)
            //    //{
            //    //    listViewRes.Add(new ListViewModel
            //    //    {
            //    //        col1 = item.ShellTermFormat,
            //    //        col2 = item.ShellTermId.ToString(),
            //    //        col3 = item.ShellTermName,
            //    //        col4 = item.ShellTermKey,
            //    //        col5 = item.ShellTermStatusId.ToString(),
            //    //        col6 = item.ShellTermGroupId.ToString(),
            //    //        col7 = groupingModel.Where(c => c.ID == item.ShellTermGroupId).Select(c => c.KEY).FirstOrDefault(),
            //    //        col8 = groupingModel.Where(c => c.ID == item.ShellTermGroupId).Select(c => c.NAME).FirstOrDefault(),
            //    //        col12 = 1500
            //    //    });
            //    //}
            //    //res = listViewRes;
            //}


            //if (operationsId == 600101 && sourceName == "StockSupplierGroupEdit1")
            //{
            //    List<ListViewModel> listViewRes = new List<ListViewModel>();

            //    using (var _context = new BSCSolution257Context())
            //    {
            //        var tmp = _context.StockSupplierModels.FromSql($"SELECT * FROM StockSupplierGroupEdit1").ToList();
            //        foreach (var item in tmp)
            //        {
            //            listViewRes.Add(new ListViewModel
            //            {
            //                col1 = item.StockSupplierID.ToString(),
            //                col2 = item.StockSupplierName,
            //                col3 = item.StockTaxID_C.ToString(),
            //                col4 = item.StockSupplierTypeID.ToString(),
            //                col5 = item.StockSupplierPhone.ToString(),
            //                col6 = item.StockSupplierAddress,
            //                col7 = item.StockSupplierAddress2,
            //                col8 = item.StockSupplierAddress3,
            //                col9 = groupingModel.Where(c => c.ID == item.StockSupplierGroupID).Select(c => c.NAME).FirstOrDefault(),
            //                col10 = groupingModel.Where(c => c.ID == item.StockSupplierGroupID).Select(c => c.NAME).FirstOrDefault(),
            //                col12 = 600101

            //            }) ;
            //        }
            //        //res = listViewRes;
            //    }
            //}


            return result;
        }
    }
}
