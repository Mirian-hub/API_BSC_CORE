using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_BSC.Models;
using System.Xml;
using System.Data.SqlClient;
using WebAPI_BSC.ClientModels;

namespace WebAPI_BSC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : Controller
    {
        
        [HttpPost]
        public string Login(UserModel model )
        {
            
            SqlParameter userKey = new SqlParameter("@ShellUserKey", model.UserName);
            SqlParameter userPassword = new SqlParameter("@ShellUserPassword", model.Password);
            SqlParameter xmlOut = new SqlParameter
            {
                ParameterName = "@xmlOut",
                SqlDbType = System.Data.SqlDbType.Xml,
                Direction = System.Data.ParameterDirection.Output
            };

            using (var context = new BSCSolution257Context())
            {
                var res =  context.Database.ExecuteSqlCommand("WebShellUser @ShellUserKey, @ShellUserPassword, @xmlOut OUTPUT", userKey, userPassword, xmlOut);
            }
            var finRes = xmlOut.Value;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(finRes.ToString());
            var _userKey = doc.GetElementsByTagName("ShellMessageKey")[0].InnerText;
            if (Int32.Parse(_userKey) >= 0)
            {
                var _userId = doc.GetElementsByTagName("ShellUserID")[0].InnerText;
                return _userId;
            }
            else
                return null;
        }

        


    }
}