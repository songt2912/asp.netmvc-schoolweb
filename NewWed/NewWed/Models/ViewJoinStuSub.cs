using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Models
{
    public class ViewJoinStuSub
    {

        public int? StudentID { get; set; }
        public string StudentName { get; set; }
        public int ExamID { get; set; }
       
        public int? SubjectID { get; set; }
        public string SubjectName { get; set; }
        public double? FistTPoin{ get; set; }
        public double? MidTPoin { get; set; }
        public double? EndTPoin { get; set; }
    }
}