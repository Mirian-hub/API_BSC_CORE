using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Xml;
using WebAPI_BSC.Controllers;
using WebAPI_BSC.Controllers.OperationSpecificModels;
using WebAPI_BSC.AppService.IAppServices;
using WebAPI_BSC.Models;
using System.Xml.Linq;
using System.Reflection;
using WebAPI_BSC.ClientModels;

namespace WebAPI_BSC.AppService.AppServicesClasses
{
    public class MainService : IMain
    {
        public List<MainModel> GetListViewData(int? operationsId, string sourceName, List<GroupModel> groupingModel, XDocument doc, int selectedRowId, string shellPageKey, int pageNumber)
        {
            List<string> colNamesFinal = new List<string>();
            List<string> colNames = new List<string>();
            List<string> conNamesTranslation = new List<string>();
            List<MainModel> result = new List<MainModel>();
            List<string> defaultNames = new List<string>();
            List<bool> isTemplateEditable = new List<bool>();
            List<string> templateTypes = new List<string>();
            List<bool> colIsSimple = new List<bool>();
            //foreach (var item in typeof(MainModel).GetProperties())
            //{
            //    propName.Add(item.Name);
            //}
            List<ChildTemplateModel> childTemplates = new List<ChildTemplateModel>();

            string groupId = null;
            string commandText = null;
            using (var context = new BSCSolution257Context())
            {
                using (var command = context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = selectedRowId >= 0 ? $"SELECT * From {sourceName} where {shellPageKey + "ID"} = {selectedRowId}" : $"SELECT * From {sourceName}";
                    commandText = command.CommandText.ToString();
                    context.Database.OpenConnection();
                    using (var reader = command.ExecuteReader())
                    {
                        int counter = 0;
                        while (reader.Read())
                        {
                            if (counter == 0)
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    colNames.Add(reader.GetName(i));
                                }
                            }
                            groupId = colNames.Where(c => c.Contains("GroupID")).FirstOrDefault();

                            switch (reader.FieldCount)
                            {
                                case 0:
                                    result = null;
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
                                        col7 = reader[6].ToString(),
                                        GroupKey = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.KEY).FirstOrDefault(),
                                        GroupName = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.NAME).FirstOrDefault()
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
                                        GroupKey = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.KEY).FirstOrDefault(),
                                        GroupName = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.NAME).FirstOrDefault()
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
                                    defaultNames.Add(reader[0].ToString());
                                    defaultNames.Add(reader[1].ToString());
                                    defaultNames.Add(reader[2].ToString());
                                    defaultNames.Add(reader[3].ToString());
                                    defaultNames.Add(reader[4].ToString());
                                    defaultNames.Add(reader[5].ToString());
                                    defaultNames.Add(reader[6].ToString());
                                    defaultNames.Add(reader[7].ToString());
                                    defaultNames.Add(reader[8].ToString());
                                    defaultNames.Add(reader[9].ToString());
                                    defaultNames.Add(reader[10].ToString());
                                    defaultNames.Add(reader[11].ToString());
                                    defaultNames.Add(reader[12].ToString());
                                    defaultNames.Add(reader[13].ToString());
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
                                        GroupKey = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.KEY).FirstOrDefault(),
                                        GroupName = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.NAME).FirstOrDefault()
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
                                case 16:
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
                                        col16 = reader[15].ToString(),
                                    }); ;
                                    break;
                                case 17:
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
                                        col16 = reader[15].ToString(),
                                        col17 = reader[16].ToString()
                                    }); ;
                                    break;

                                case 18:
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
                                        col16 = reader[15].ToString(),
                                        col17 = reader[16].ToString(),
                                        col18 = reader[17].ToString(),
                                    }); ;
                                    break;
                                case 19:
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
                                        col16 = reader[15].ToString(),
                                        col17 = reader[16].ToString(),
                                        col18 = reader[17].ToString(),
                                        col19 = reader[18].ToString()
                                    });
                                    break;
                                case 20:
                                    defaultNames.Add(reader[0].ToString());
                                    defaultNames.Add(reader[1].ToString());
                                    defaultNames.Add(reader[2].ToString());
                                    defaultNames.Add(reader[3].ToString());
                                    defaultNames.Add(reader[4].ToString());
                                    defaultNames.Add(reader[5].ToString());
                                    defaultNames.Add(reader[6].ToString());
                                    defaultNames.Add(reader[7].ToString());
                                    defaultNames.Add(reader[8].ToString());
                                    defaultNames.Add(reader[9].ToString());
                                    defaultNames.Add(reader[10].ToString());
                                    defaultNames.Add(reader[11].ToString());
                                    defaultNames.Add(reader[12].ToString());
                                    defaultNames.Add(reader[13].ToString());
                                    defaultNames.Add(reader[14].ToString());
                                    defaultNames.Add(reader[15].ToString());
                                    defaultNames.Add(reader[16].ToString());
                                    defaultNames.Add(reader[17].ToString());
                                    defaultNames.Add(reader[18].ToString());
                                    defaultNames.Add(reader[19].ToString());
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
                                        col16 = reader[15].ToString(),
                                        col17 = reader[16].ToString(),
                                        col18 = reader[17].ToString(),
                                        col19 = reader[18].ToString(),
                                        col20 = reader[19].ToString(),
                                        GroupKey = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.KEY).FirstOrDefault(),
                                        GroupName = groupingModel.Where(c => c.ID.ToString() == reader[groupId].ToString()).Select(c => c.NAME).FirstOrDefault()
                                    });
                                    break;
                            }
                            counter++;
                        }
                    }
                }
                if (result.Count != 0)
                {
                    result.First().operationId = operationsId ?? default(int);
                    result.First().ExecutedQuery = commandText;
                    var tmp = result.First();
                    result.First().DefaultColNames = defaultNames;
                }
                // ------------------------------------- Get Child Templates ---------------------------------------------------------
                //< ShellControlID > 5 </ ShellControlID >

                //< ShellControlKey > StockCompanyItemUnitName </ ShellControlKey >

                //< ShellControlName > ერთეულის დასახელება </ ShellControlName >

                //< ShellControlType > Text </ ShellControlType >

                //< ShellControlEdit > 1 </ ShellControlEdit >

                //< ShellControlWidth > 1500 </ ShellControlWidth >

                //< ShellTermFormat > T:Text / E:1 / W:1500 /</ ShellTermFormat >
                if (pageNumber >= 0)
                {
                    int columnNumCounter = 1;
                    foreach (var item in colNames)
                    {
                        List<string> childTemplateDefaultColNames = new List<string>();
                        List<string> childTemplateColNameTrans = new List<string>();
                        List<string> childTemplateTypes = new List<string>();
                        List<bool> childIsEditableList = new List<bool>();
                        List<string> templateFormatter = new List<string>();
                        var targetNode = doc.Element("ShellData").Element("ShellControlList").Elements("ShellControl")
                                            .Where(e => e.Element("ShellControlKey").Value == item).FirstOrDefault();
                        if (targetNode != null)
                        {
                            string sqlQuery = targetNode.Element("ShellControlSource") != null ? targetNode.Element("ShellControlSource").Value : null;
                            string shellControlID = targetNode.Element("ShellControlID").Value;
                            string shellControlKey = targetNode.Element("ShellControlKey").Value;
                            string shellControlName = targetNode.Element("ShellControlName").Value;
                            string shellControlType = targetNode.Element("ShellControlType").Value;
                            string shellControlEdit = targetNode.Element("ShellControlEdit").Value;

                            using (var command = context.Database.GetDbConnection().CreateCommand())
                            {
                                int counterTemp = 0;
                                if (sqlQuery != null)
                                {
                                    command.CommandText = sqlQuery;
                                    context.Database.OpenConnection();
                                    using (var reader = command.ExecuteReader())
                                    {
                                        while (reader.Read())
                                        {
                                            switch (reader.FieldCount)
                                            {
                                                case 0:
                                                    break;
                                                case 1:
                                                    if (counterTemp == 0)
                                                    {
                                                        childTemplateDefaultColNames.Add(reader.GetName(0));
                                                    }
                                                    childTemplates.Add(new ChildTemplateModel
                                                    {
                                                        Col1 = reader[0].ToString(),
                                                    }); counterTemp++; break;
                                                case 2:
                                                    if (counterTemp == 0)
                                                    {
                                                        childTemplateDefaultColNames.Add(reader.GetName(0));
                                                        childTemplateDefaultColNames.Add(reader.GetName(1));

                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(0), "ShellControlName"));
                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(1), "ShellControlName"));

                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(0), "ShellControlType"));
                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(1), "ShellControlType"));

                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(0)));
                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(1)));

                                                        templateFormatter.Add(columnNumCounter + "_1");
                                                        templateFormatter.Add(columnNumCounter + "_2");

                                                    }
                                                    childTemplates.Add(new ChildTemplateModel
                                                    {
                                                        Col1 = reader[0].ToString(),
                                                        Col2 = reader[1].ToString(),
                                                        NumberOfColumn = 2,
                                                        ParentColumnName = GetValueByTagName(item, "ShellControlName"),
                                                        ColumnNames = childTemplateColNameTrans,
                                                        IsEditableList = childIsEditableList,
                                                        ColumnTemlateTypes = childTemplateTypes,
                                                        TemplateFromatter = templateFormatter

                                                    }); counterTemp++; break;
                                                case 3:
                                                    if (counterTemp == 0)
                                                    {
                                                        childTemplateDefaultColNames.Add(reader.GetName(0));
                                                        childTemplateDefaultColNames.Add(reader.GetName(1));
                                                        childTemplateDefaultColNames.Add(reader.GetName(2));

                                                        var tmp = reader.GetName(0);
                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(0), "ShellControlName"));
                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(1), "ShellControlName"));
                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(2), "ShellControlName"));

                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(0), "ShellControlType"));
                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(1), "ShellControlType"));
                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(2), "ShellControlType"));

                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(0)));
                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(1)));
                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(2)));

                                                        templateFormatter.Add(columnNumCounter + "_1");
                                                        templateFormatter.Add(columnNumCounter + "_2");
                                                        templateFormatter.Add(columnNumCounter + "_3");

                                                    }
                                                    childTemplates.Add(new ChildTemplateModel
                                                    {
                                                        Col1 = reader[0].ToString(),
                                                        Col2 = reader[1].ToString(),
                                                        Col3 = reader[2].ToString(),
                                                        ParentColumnName = GetValueByTagName(item, "ShellControlName"),
                                                        NumberOfColumn = 3,
                                                        ColumnNames = childTemplateColNameTrans,
                                                        IsEditableList = childIsEditableList,
                                                        ColumnTemlateTypes = childTemplateTypes,
                                                        TemplateFromatter = templateFormatter                                                     
                                                    }); counterTemp++; break;
                                                case 4:
                                                    if (counterTemp == 0)
                                                    {
                                                        childTemplateDefaultColNames.Add(reader.GetName(0));
                                                        childTemplateDefaultColNames.Add(reader.GetName(1));
                                                        childTemplateDefaultColNames.Add(reader.GetName(2));
                                                        childTemplateDefaultColNames.Add(reader.GetName(3));

                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(0), "ShellControlName"));
                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(1), "ShellControlName"));
                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(2), "ShellControlName"));
                                                        childTemplateColNameTrans.Add(GetValueByTagName(reader.GetName(3), "ShellControlName"));

                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(0), "ShellControlType"));
                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(1), "ShellControlType"));
                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(2), "ShellControlType"));
                                                        childTemplateTypes.Add(GetValueByTagName(reader.GetName(3), "ShellControlType"));

                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(0)));
                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(1)));
                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(2)));
                                                        childIsEditableList.Add(CheckIfColumnIsEditable(reader.GetName(3)));

                                                        templateFormatter.Add(columnNumCounter + "_1");
                                                        templateFormatter.Add(columnNumCounter + "_2");
                                                        templateFormatter.Add(columnNumCounter + "_3");
                                                        templateFormatter.Add(columnNumCounter + "_4");

                                                    }
                                                    childTemplates.Add(new ChildTemplateModel
                                                    {
                                                        Col1 = reader[0].ToString(),
                                                        Col2 = reader[1].ToString(),
                                                        Col3 = reader[2].ToString(),
                                                        Col4 = reader[3].ToString(),
                                                        ParentColumnName = GetValueByTagName(item, "ShellControlName"),
                                                        NumberOfColumn = 4,
                                                        ColumnNames = childTemplateColNameTrans,
                                                        IsEditableList = childIsEditableList,
                                                        ColumnTemlateTypes = childTemplateTypes,
                                                        TemplateFromatter = templateFormatter
                                                    }); counterTemp++; break;
                                            }
                                        }
                                    }

                                    columnNumCounter++;

                                }
                            }
                        }
                    }
                }

                    //---------------------------------------------------------------------------------------------------------------------

                    foreach (var item in colNames)
                    {
                        var targetNode = doc.Element("ShellData").Element("ShellControlList").Elements("ShellControl").Where(e => e.Element("ShellControlKey").Value == item).FirstOrDefault();
                        if (targetNode != null)
                            conNamesTranslation.Add(targetNode.Element("ShellControlName").Value);
                        else
                            conNamesTranslation.Add(item);

 
                        isTemplateEditable.Add(CheckIfColumnIsEditable(item));
                        templateTypes.Add(GetValueByTagName(item, "ShellControlType"));
                        colIsSimple.Add(ColumnIsSimple(item));
                    }
                    if (result.Count != 0)
                    {
                        result.First().colNames = conNamesTranslation.ToList();
                        result.First().ColumnIsEditable = isTemplateEditable;
                        result.First().ColTemplateTypes = templateTypes;
                        result.First().ChildTemplates = childTemplates;
                        result.First().colIsSimple = colIsSimple;
                    }

                    else
                        result.Add(new MainModel
                        {
                            colNames = conNamesTranslation.ToList()
                        });
                }



                string GetValueByTagName(string source, string searchObjectName)
                {
                    var targetNode = doc.Element("ShellData").Element("ShellControlList").Elements("ShellControl").Where(e => e.Element("ShellControlKey").Value == source).FirstOrDefault();
                    if (targetNode != null)
                    {
                        var resultVal = targetNode.Element(searchObjectName).Value;
                        if (resultVal == null)
                            return source;
                        else
                            return resultVal;
                    }
                    else
                        return source;
                }
                bool CheckIfColumnIsEditable(string colName)
                {
                    var targetNode = doc.Element("ShellData").Element("ShellControlList").Elements("ShellControl").Where(e => e.Element("ShellControlKey").Value == colName).FirstOrDefault();
                    if (targetNode != null)
                        return targetNode.Element("ShellControlEdit").Value == "1" ? true : false;
                    else
                        return false;

                }

            bool ColumnIsSimple (string colName)
            {
                var targetNode = doc.Element("ShellData").Element("ShellControlList").Elements("ShellControl").Where(e => e.Element("ShellControlKey").Value == colName).FirstOrDefault();
                if (targetNode != null)
                {
                    var resultVal = targetNode.Element("ShellControlSource");
                    if (resultVal == null)
                        return true;
                    else
                        return false;
                }
                else
                    return true;
            }
                return result;
            }
        }
    }
