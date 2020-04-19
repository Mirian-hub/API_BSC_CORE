using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_BSC.ClientModels;
using WebAPI_BSC.Models;
using WebAPI_BSC.AppService.IAppServices;
using System.Xml.Linq;

namespace WebAPI_BSC.Controllers
{
    [Route("api/[controller]/{operationId}")]
    [ApiController]
    public class ListViewController : ControllerBase
    {
        private readonly IMain _mainSerice;
        public ListViewController(IMain main)
        {
            _mainSerice = main;
        }
        [HttpGet]
        public List<MainModel> GetListView(int  operationId, int? editPageNumber)
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


            var listViewSourceName = doc.GetElementsByTagName("ShellPageSource")[0].InnerText;

            return _mainSerice.GetListViewData(opId, listViewSourceName,groupModels, docTemplate);
            }

        }

    }
