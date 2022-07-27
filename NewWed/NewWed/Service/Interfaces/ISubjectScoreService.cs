using NewWed.Data;
using NewWed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWed.Service.Interfaces
{
    public interface ISubjectScoreService
    {
        IEnumerable<ExamScoreDto> GetSubjectScore();

        void AddSubjectScore(ExamScore subjectScore);
        void UpdateSubjectScroce(ExamScore subjectScore);
        void DeleteSubjectScore(int id);
        ExamScore GetId(int id);
    }
}
