using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_BSC.ClientModels
{
    public class ManuVModel
    {
        public string Message { get; set; }
        public int Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public bool HasChild { get; set; }
        public bool IsGroup { get; set; }
    }
}
