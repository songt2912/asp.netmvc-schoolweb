using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Models
{
    public class ClassRoomDto
    {
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public int? TotalStudent { get; set; }
    }
}