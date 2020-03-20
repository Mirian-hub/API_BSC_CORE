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

namespace WebAPI_BSC.Controllers
{
    [Route("api/[controller]/{id}")]
    [ApiController]
    public class ListViewController : ControllerBase
    {
        [HttpGet]
        public List<ListViewModel> GetListView(int ? id)
        {
            SqlParameter userId = new SqlParameter("@ShellUserID", '0');
            SqlParameter operationId = new SqlParameter("@ShellOperationID", "1500");
            SqlParameter xmlOut = new SqlParameter
            {
                ParameterName = "@xmlOut",
                SqlDbType = System.Data.SqlDbType.Xml,
                Direction = System.Data.ParameterDirection.Output
            };
            List<GroupModel> groupModels = new List<GroupModel>();   

            using (var context = new BSCSolution257Context())
            {
                var res = context.Database.ExecuteSqlCommand("WebShellTerm @ShellUserID, @ShellOperationID, @xmlOut OUTPUT", userId, operationId, xmlOut);
                groupModels = context.GroupModels.FromSql("select * from ShellTermGroupList(1500)").ToList(); 
            }
            var finRes = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(finRes.ToString());
            var listViewSourceName = doc.GetElementsByTagName("ShellPageSource")[0].InnerText;

            List<ListViewModel> listViewRes = new List<ListViewModel>();

            List<dynamic> listViews = new List<dynamic>();

            using (var _context = new BSCSolution257Context())
            {
                var listView = (IEnumerable<dynamic>)(_context.GetType().GetProperty(listViewSourceName).GetValue(_context, null));
                listViews = listView.Select(o => o).ToList();
                foreach (var item in listViews)
                {
                    listViewRes.Add(new ListViewModel
                    {
                        Format = item.ShellTermFormat,
                        Id = item.ShellTermId,
                        Name = item.ShellTermName,
                        Key = item.ShellTermKey,
                        Code = item.ShellTermStatusId,
                        GroupId = item.ShellTermGroupId,
                        GroupKey = groupModels.Where(c=>c.ID==item.ShellTermGroupId).Select(c=>c.KEY).FirstOrDefault(),
                        GroupName = groupModels.Where(c=>c.ID==item.ShellTermGroupId).Select(c=>c.NAME).FirstOrDefault(),

                    });
                }
                return listViewRes;
            }

        }

    }
}