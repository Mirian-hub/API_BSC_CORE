using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_BSC.AppService.IAppServices;
using WebAPI_BSC.Models;

namespace WebAPI_BSC.Controllers
{
    [Route("api/[controller]/{controlKey}")]
    [ApiController]
    public class InnerListViewController : ControllerBase
    {
        private IInnerListViewService _service;
        public InnerListViewController(IInnerListViewService service)
        {
            this._service = service;
        }
        [HttpGet]
        public List<InnerListViewModel> GetStockItems(string controlKey)
        {
            List<InnerListViewModel> res = new List<InnerListViewModel>();
            SqlParameter userId = new SqlParameter("@ShellUserID", '0');
            SqlParameter templateXmlOut = new SqlParameter
            {
                ParameterName = "@tempXmlOut",
                SqlDbType = System.Data.SqlDbType.Xml,
                Direction = System.Data.ParameterDirection.Output
            };
            using (var context = new BSCSolution257Context())
            {
                context.Database.ExecuteSqlCommand("WebShellTerm_ControlList @ShellUserID, @tempXmlOut OUTPUT", userId, templateXmlOut);
            }
            var finResTemp = templateXmlOut.Value;
            XmlDocument docTemp = new XmlDocument();
            docTemp.LoadXml(finResTemp.ToString());
            var doc = XDocument.Parse(docTemp.OuterXml);

            var targetNode = doc.Element("ShellData").Element("ShellControlList").Elements("ShellControl")
                                 .Where(e => e.Element("ShellControlKey").Value == controlKey).FirstOrDefault();
            string sqlQuery = targetNode.Element("ShellControlSource").Value;

            //using (var context = new BSCSolution257Context())
            //{
            //    res = context.StockItemModel.FromSql(sqlQuery).ToList();
            //    //   context.Database.ExecuteSqlCommand("WebShellTerm_ControlList @ShellUserID, @tempXmlOut OUTPUT", userId, templateXmlOut);
            //}
              
            return _service.GetData(sqlQuery);
        }
    }
}