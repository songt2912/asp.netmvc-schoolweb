using NewWed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace NewWed.Service.Interfaces
{
    public interface IAllTable
    {
        IEnumerable<AlltableDto> GetAll();
        
        
        IEnumerable<AlltableDto> GetTop10();
        IEnumerable<AlltableDto> ClassificationAll();
         IEnumerable<Models.SubjectDto> GetSubject();
        IEnumerable<AlltableDto> Seachingbarforschool(string studentName, string className, string subjectName, string roles4student);

    }
}
