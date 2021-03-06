﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_BSC.Controllers;
using WebAPI_BSC.Models;
using WebAPI_BSC.AppService.IAppServices;
using System.Xml.Linq;

namespace WebAPI_BSC.Controllers
{
    [Route("api/[controller]/{operationId}/{editPageId}/{selectedRowId}")]
    [ApiController]
    public class ListViewController : ControllerBase
    {
        private readonly IMain _mainService;
        public ListViewController(IMain main)
        {
            _mainService = main;
        }   
        [HttpGet]
        public List<MainModel> GetListView(int  operationId, int editPageId, int selectedRowId)
        {
            int opId = operationId;
            SqlParameter userId = new SqlParameter("@ShellUserID",'0' );
            SqlParameter _operationId = new SqlParameter("@ShellOperationID",opId);
            SqlParameter xmlOut = new SqlParameter  
            {
                ParameterName = "@xmlOut",
                SqlDbType = System.Data.SqlDbType.Xml,
                Direction = System.Data.ParameterDirection.Output
            };

            SqlParameter templateXmlOut = new SqlParameter
            {
                ParameterName = "@tempXmlOut",
                SqlDbType = System.Data.SqlDbType.Xml,
                Direction = System.Data.ParameterDirection.Output
            };
            List<GroupModel> groupModels = new List<GroupModel>();   

            using (var context = new BSCSolution257Context())
            {

                var res = context.Database.ExecuteSqlCommand("WebShellTerm @ShellUserID, @ShellOperationID, @xmlOut OUTPUT", userId, _operationId, xmlOut);
                groupModels = context.GroupModels.FromSql($"select * from ShellTermGroupList({opId})").ToList();
                context.Database.ExecuteSqlCommand("WebShellTerm_ControlList @ShellUserID, @tempXmlOut OUTPUT", userId, templateXmlOut);
            }
            var finRes = xmlOut.Value;  
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(finRes.ToString());

            var finResTemp = templateXmlOut.Value;
            XmlDocument docTemp = new XmlDocument();
            docTemp.LoadXml(finResTemp.ToString());

            var docTemplate = XDocument.Parse(docTemp.OuterXml);

            string shellPageKey = XDocument.Parse(doc.OuterXml).Descendants("ShellPageKey").First().Value;
            var listViewSourceName = editPageId<0? doc.GetElementsByTagName("ShellPageSource")[0].InnerText: shellPageKey + "Edit"+editPageId;
            //var listViewSourceName1 = doc.GetElementsByTagName("ShellPageSource")[0].InnerText;
            //var listViewSourceName2 = XDocument.Parse(doc.OuterXml).Descendants("ShellPageKey").First().Value + "Edit"+editPageId;

            var finalRes = _mainService.GetListViewData(opId, listViewSourceName, groupModels, docTemplate, selectedRowId, shellPageKey, editPageId);
            return finalRes;
            }

        }

    }
