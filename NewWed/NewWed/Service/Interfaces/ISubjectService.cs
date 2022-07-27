using NewWed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Service.Interfaces
{
    public interface ISubjectService
    {
        IEnumerable<Models.SubjectDto> GetSubject();
        void AddSubject(SubjectDto subject);
        void UpdateSubject(SubjectDto subject);
        void DeleteSubject(int id);
        SubjectDto GetId(int id);
    }
}