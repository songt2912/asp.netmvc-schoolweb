using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace NewWed.Data
{
    public interface ISchoolEntitiesData
    {
        DbSet<Student> Students { get; set; }
        DbSet<ClassRoom> ClassRooms { get; set; }
        DbSet<Subject> Subjects { get; set; }
        DbSet<ExamScore> ExamScores { get; set; }
        ObjectResult<AllTableinOne_Result> AllTableinOne();
        ObjectResult<Seachingbarforschool_Result> Seachingbarforschool(string studentName, string className, string subjectName, string roles4student);
        ObjectResult<Top10Student_Result> Top10Student();
        void SaveChanges();
        void Remove();
        void Find();
        void Modified();
    }
}