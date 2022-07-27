using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Models
{
    public class AlltableDto
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> StudentAge { get; set; }
        public Nullable<int> ClassID { get; set; }
        public string ClassName { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public string SubjectName { get; set; }
        public Nullable<int> ExamID { get; set; }
        public Nullable<double> FirstTPoint { get; set; }
        public Nullable<double> MidTPoint { get; set; }
        public Nullable<double> LastTPoint { get; set; }
        public Nullable<double> AvgScore { get; set; }
        public string Roles { get; set; }
    }
}