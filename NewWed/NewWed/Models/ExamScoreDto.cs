using NewWed.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Models
{
    public class ExamScoreDto
    {
        public int ExamID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> SubjectID { get; set; }
        public Nullable<double> FirstTPoint { get; set; }
        public Nullable<double> MidTPoint { get; set; }
        public Nullable<double> LastTPoint { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}