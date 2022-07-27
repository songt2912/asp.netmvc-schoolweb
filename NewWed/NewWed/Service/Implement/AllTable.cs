using NewWed.Data;
using NewWed.Models;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWed.Service.Implement
{
    public class AllTable : IAllTable
    {
        private ISchoolEntitiesData _tStudentEntities;

        public AllTable(ISchoolEntitiesData tStudentEntities)
        {
            _tStudentEntities = tStudentEntities;
        }
        public IEnumerable<AlltableDto> GetAll()
        {
            var all = _tStudentEntities.Top10Student().ToList();
            
            return all.Select(x=>new AlltableDto {

                StudentID = x.StudentID,
                StudentName = x.StudentName,
                ClassID = x.ClassID,
                ClassName = x.ClassName,
                SubjectID = x.SubjectID,
                SubjectName = x.SubjectName,
                ExamID = x.ExamID,
                FirstTPoint = x.FirstTPoint,
                MidTPoint = x.MidTPoint,
                LastTPoint = x.LastTPoint,
                AvgScore = x.AvgScore,
                Roles = x.Roles,



            }).ToList();

        }

  

        public IEnumerable<AlltableDto> SeachbyScore(string seachString)
        {
            var all = _tStudentEntities.AllTableinOne().ToList();

            return all.Select(x => new AlltableDto
            {
                StudentName = x.StudentName,

                ClassName = x.ClassName,
                SubjectName = x.SubjectName,

                FirstTPoint = x.FirstTPoint,
                MidTPoint = x.MidTPoint,
                LastTPoint = x.LastTPoint,
                AvgScore = x.AvgScore,

            }).ToList();

        }

    

      
        public IEnumerable<AlltableDto> GetByScoreRole()
        {
            var all = _tStudentEntities.AllTableinOne();

            return all.Select(x => new AlltableDto
            {
               
                StudentName = x.StudentName,

                ClassName = x.ClassName,
                SubjectName = x.SubjectName,
                FirstTPoint = x.FirstTPoint,
                MidTPoint = x.MidTPoint,
                LastTPoint = x.LastTPoint,
                AvgScore = x.AvgScore,
                Roles = x.Roles
            }).ToList();
        }
        public IEnumerable<AlltableDto> GetClass() {
            var all = _tStudentEntities.ClassRooms.ToList();

            return all.Select(x => new AlltableDto
            {
               ClassName=x.ClassName
            }).ToList();
            

        }

        public IEnumerable<AlltableDto> GetTop10()
        {
            var all = _tStudentEntities.AllTableinOne().ToList();
            return all.Select(x => new AlltableDto
            {

                StudentName = x.StudentName,

                ClassName = x.ClassName,
                SubjectName = x.SubjectName,
                FirstTPoint = x.FirstTPoint,
                MidTPoint = x.MidTPoint,
                LastTPoint = x.LastTPoint,
                AvgScore = x.AvgScore,
                Roles = x.Roles
            }).ToList();
        }

        public IEnumerable<AlltableDto> ClassificationAll()
        {
            var all = _tStudentEntities.AllTableinOne().ToList();
     
            return all.Select(x => new AlltableDto
            {
                StudentID=x.StudentID,
                StudentName = x.StudentName,
                ClassID=x.ClassID,
                ClassName = x.ClassName,
                SubjectID=x.SubjectID,
                SubjectName = x.SubjectName,
                ExamID=x.ExamID,
                FirstTPoint = x.FirstTPoint,
                MidTPoint = x.MidTPoint,
                LastTPoint = x.LastTPoint,
                AvgScore = x.AvgScore,
                Roles=x.Roles,
            }).ToList();

        }

        public IEnumerable<Models.SubjectDto> GetSubject()
        {
            var tests = _tStudentEntities.Subjects;

            return tests.Select(x => new Models.SubjectDto
            {
                SubjectID = x.SubjectID,
                SubjectName = x.SubjectName,

            });
        }

        public IEnumerable<AlltableDto> Seachingbarforschool(string studentName, string className, string subjectName, string roles4student)
        {
            var all = _tStudentEntities.Seachingbarforschool(studentName, className,  subjectName, roles4student)
            //.Where(x=>x.StudentName==studentName && x.ClassName== className&& x.SubjectName== subjectName&& x.Roles== roles4student ||
            //          x.StudentName == studentName && x.ClassName == className && x.SubjectName == subjectName && x.Roles == ""     ||
            //          x.StudentName == studentName && x.ClassName == className && x.SubjectName == "" && x.Roles == ""              ||
            //          x.StudentName == studentName && x.ClassName == "" && x.SubjectName == "" && x.Roles == ""

            //)
                .ToList();

            return all.Select(x => new AlltableDto
            {
                StudentID = x.StudentID,
                StudentName = x.StudentName,
                ClassID = x.ClassID,
                ClassName = x.ClassName,
                SubjectID = x.SubjectID,
                SubjectName = x.SubjectName,
                ExamID = x.ExamID,
                FirstTPoint = x.FirstTPoint,
                MidTPoint = x.MidTPoint,
                LastTPoint = x.LastTPoint,
                AvgScore = x.AvgScore,
                Roles = x.Roles,
            }).ToList();
        }
    }
}

