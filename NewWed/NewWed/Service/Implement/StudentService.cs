
using NewWed.Data;
using NewWed.Models;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Service.Implement
{
    public class StudentService : IStudentService

    {
        private ISchoolEntitiesData _tStudentEntities;

        public StudentService(ISchoolEntitiesData tStudentEntities)
        {
            _tStudentEntities = tStudentEntities;
        }
        //public IEnumerable<Models.ViewJoinSC> GetStudents(string searchString)
        //{

        //    var students = (from s in _tStudentEntities.Students
        //                    join c in _tStudentEntities.ClassRooms on s.ClassID equals c.ClassID
        //                    select new ViewJoinSC
        //                    {
        //                        StudentID = s.StudentID,
        //                        StudentName = s.StudentName,
        //                        StudentAge = s.StudentAge,
        //                        ClassID = c.ClassID,
        //                        ClassName = c.ClassName,
        //                    }).ToList();
        //    if (!string.IsNullOrEmpty(searchString))
        //    {

        //        students = students.Where(s => s.StudentName.Contains(searchString)).ToList();

        //    }
        //    else
        //    {

        //        int ad = Convert.ToInt16(searchString);
        //        students = students.Where(s => s.StudentID == ad).ToList();


        //    }


        //    var _class = _tStudentEntities.ClassRooms.ToList();
        //    var lst = students.Join(_class,
        //        s => s.ClassID,
        //        c => c.ClassID,
        //        (s, c) => new
        //        {
        //            ClassIds = s.ClassID,
        //            ClassNames = c.ClassName,
        //        });

        //    return students;

        //}




        public void AddStudent(StudentDto student)
        {
            var i = _tStudentEntities.Students.Add(new Student
            {
                StudentID = student.StudentID,
                StudentName = student.StudentName,
                StudentAge = student.StudentAge,
                ClassID = student.ClassID
            });
            _tStudentEntities.SaveChanges();
        }

        public void UpdateStudent(StudentDto student) {
            var i = _tStudentEntities.Students.Where(x => x.StudentID == student.StudentID).FirstOrDefault();
            if (i != null) {
                i.StudentID = student.StudentID;
                i.StudentName = student.StudentName;
                i.StudentAge = student.StudentAge;
                i.ClassID = student.ClassID;
            }
            _tStudentEntities.SaveChanges();
        }

       

        public StudentDto GetId(int id)
        {
            var i = _tStudentEntities.Students.FirstOrDefault(x => x.StudentID == id);
            var convert = new StudentDto()
            {
                StudentID = i.StudentID,
                StudentName = i.StudentName,
                StudentAge = i.StudentAge,
                ClassID = i.ClassID

            };
            return convert;


        }

        public void DeleteStudent(int id)
        {
                var i = _tStudentEntities.Students.FirstOrDefault(x => x.StudentID == id);
                _tStudentEntities.Students.Remove(i);
                _tStudentEntities.SaveChanges();
        }

        public void RegisterStudent(StudentDto student)
        {
            var i = _tStudentEntities.Students.Where(x => x.StudentID == student.StudentID).FirstOrDefault();
            if (i != null)
            {
                i.StudentID = student.StudentID;
                i.StudentName = student.StudentName;
                i.StudentAge = student.StudentAge;
                i.ClassID = student.ClassID;
            }
            _tStudentEntities.SaveChanges();
        }
 
        public IEnumerable<StudentDto> GetStudents()
        {
            var tests = _tStudentEntities.Students.ToList();

            return tests.Select(x => new Models.StudentDto
            {
                StudentID = x.StudentID,
                StudentName = x.StudentName,
                StudentAge = x.StudentAge,
                ClassID = x.ClassID,
                classRoom=x.ClassRoom,

            });
        }



       

}

      
    }





