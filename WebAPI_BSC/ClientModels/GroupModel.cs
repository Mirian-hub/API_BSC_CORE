using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_BSC.Controllers
{
    public class GroupModel
    {
        public int ID { get; set; }
        public string KEY { get; set; }
        public string NAME { get; set; }
        public  int PID { get; set; }
        public  int LID { get; set; }
        public string SID { get; set; }
    }
}
