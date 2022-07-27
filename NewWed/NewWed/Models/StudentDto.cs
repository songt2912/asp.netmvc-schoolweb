using NewWed.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Models
{
    public class StudentDto

    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int? StudentAge { get; set; }
        public int? ClassID { get; set; }
        public ClassRoom classRoom { get; set; }

    }
}