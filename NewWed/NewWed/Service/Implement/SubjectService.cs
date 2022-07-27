using NewWed.Data;
using NewWed.Models;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace NewWed.Service.Implement
{
    public class SubjectService : ISubjectService
    {
        private ISchoolEntitiesData _schoolEntities;

        public SubjectService(ISchoolEntitiesData schoolEntities)
        {
            _schoolEntities = schoolEntities;
        }

        public void AddSubject(SubjectDto subject)
        {
            var i = _schoolEntities.Subjects.Add(new Subject
            {
                SubjectID = subject.SubjectID,
                SubjectName = subject.SubjectName,
                

            });
            _schoolEntities.SaveChanges();
        }

        public SubjectDto GetId(int id)
        {
            var i = _schoolEntities.Subjects.FirstOrDefault(x => x.SubjectID == id);
            var sub = new SubjectDto()
            {
                SubjectID = i.SubjectID,
                SubjectName = i.SubjectName


            };
            return sub;
        }

        public void DeleteSubject(int id)
        {
            
                var i = _schoolEntities.Subjects.Where(x => x.SubjectID == id).FirstOrDefault();
          
                _schoolEntities.Subjects.Remove(i);
                _schoolEntities.SaveChanges();
            
            
    }
            

        public IEnumerable<Models.SubjectDto> GetSubject()
        {
            var tests = _schoolEntities.Subjects;

            return tests.Select(x => new Models.SubjectDto
            {
                SubjectID = x.SubjectID,
                SubjectName = x.SubjectName,

            });
        }

        public void UpdateSubject(SubjectDto subject)
        {
            var i = _schoolEntities.Subjects.Where(x => x.SubjectID == subject.SubjectID).FirstOrDefault();
            if (i != null)
            {
                i.SubjectID = subject.SubjectID;
                i.SubjectName = subject.SubjectName;
               

            }
            _schoolEntities.SaveChanges();
        }



    }
}