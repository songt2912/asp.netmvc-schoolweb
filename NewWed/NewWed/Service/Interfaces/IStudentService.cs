using NewWed.Data;
using NewWed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewWed.Service.Interfaces
{
    public interface IStudentService
    {
        
        void AddStudent(StudentDto student);
        void UpdateStudent(StudentDto student);
        void DeleteStudent(int id);
        StudentDto GetId(int id);
        void RegisterStudent(StudentDto student);

        IEnumerable<StudentDto> GetStudents();
        
      
        //test

    }
}