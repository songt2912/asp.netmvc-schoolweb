using NewWed.Data;
using NewWed.Models;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWed.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentSevervice;

        public StudentController(IStudentService studentSevervice)
        {
            _studentSevervice = studentSevervice;
        }
        public ActionResult Index(string searchString)
        {
            var s = _studentSevervice.GetStudents().Take(20);

            return View(s);

        }

        public ActionResult Create()
        {
            return View(new StudentDto());
        }

        public ActionResult Edit(int id)
        {

            return View(_studentSevervice.GetId(id));

        }

        [HttpPost]
        public ActionResult Edit(StudentDto student)
        {
            _studentSevervice.UpdateStudent(student);

            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Create(StudentDto studentDto)
        {
            _studentSevervice.AddStudent(studentDto);
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            return View(_studentSevervice.GetId(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            _studentSevervice.DeleteStudent(id);

            return RedirectToAction("Index");

        }
        public ActionResult Details(int id)
        {
            return View(_studentSevervice.GetId(id));
        }
        [HttpPost, ActionName(" Regiter")]
        
        public ActionResult Details(StudentDto student)
        {
            _studentSevervice.UpdateStudent(student);
           
            return RedirectToAction("Index");

        }
      


    }
}
