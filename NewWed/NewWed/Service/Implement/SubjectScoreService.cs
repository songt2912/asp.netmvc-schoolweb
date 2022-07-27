using NewWed.Data;
using NewWed.Models;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Service.Implement
{
    
        public class SubjectScoreService : ISubjectScoreService
            {
            private Data.ISchoolEntitiesData _schoolEntities;

            public SubjectScoreService(ISchoolEntitiesData schoolEntities)
            {
                _schoolEntities = schoolEntities;
            }

        public void AddSubjectScore(ExamScore subjectScore)
        {
            
            var i = _schoolEntities.ExamScores.Add(new ExamScore {
                ExamID= subjectScore.ExamID,
                StudentID =subjectScore.StudentID,
                SubjectID=subjectScore.SubjectID,
                FirstTPoint=subjectScore.FirstTPoint,
                MidTPoint=subjectScore.MidTPoint,
                LastTPoint=subjectScore.LastTPoint,



            });
            _schoolEntities.SaveChanges();
        }

        public void DeleteSubjectScore(int id)
        {
            var i = _schoolEntities.ExamScores.FirstOrDefault(x => x.ExamID == id);
            _schoolEntities.ExamScores.Remove(i);
            _schoolEntities.SaveChanges();

        }

        public ExamScore GetId(int id)
        {
            
                var i = _schoolEntities.ExamScores.FirstOrDefault(x => x.ExamID == id);

                var convert = new ExamScore()
                {

                    ExamID = i.ExamID,
                    StudentID = i.StudentID,
                    SubjectID = i.SubjectID,
                    FirstTPoint = i.FirstTPoint,
                    MidTPoint = i.MidTPoint,
                    LastTPoint = i.LastTPoint,


                };
                return convert;


            

        }


        //show
        public IEnumerable<ExamScoreDto> GetSubjectScore()
        {
            //var test = _schoolEntities.SubjectScores;
            //return test.Select(x => new Models.SubjectScoreDto
            //{
            //    ExamID=x.ExamID,
            //    StudentID=x.StudentID,
            //    SubjectID=x.SubjectID,
            //    AvgScore=x.AvgScore,

            //});
            var score = (from ss in _schoolEntities.ExamScores
                         
                         select new ExamScoreDto
                         {
                             Student=ss.Student,
                             Subject=ss.Subject,
                             ExamID = ss.ExamID,
                             StudentID = ss.StudentID,
                             SubjectID = ss.SubjectID,
                             FirstTPoint = ss.FirstTPoint,
                             MidTPoint=ss.MidTPoint,
                             LastTPoint=ss.LastTPoint,





                         }).ToList();
            return score;
        }

        //get id for update & delete
       
        public void UpdateSubjectScroce(ExamScore subjectScore)
        {
            var i = _schoolEntities.ExamScores.Where(x => x.ExamID == subjectScore.ExamID).FirstOrDefault();
            if (i != null)
            {
                i.ExamID = subjectScore.ExamID;
                i.StudentID = subjectScore.ExamID;
                i.SubjectID = subjectScore.SubjectID;
                i.FirstTPoint = subjectScore.FirstTPoint;
                i.MidTPoint = subjectScore.StudentID;
                i.LastTPoint = subjectScore.LastTPoint;

            }
            _schoolEntities.SaveChanges();
        }

    
    }
}
