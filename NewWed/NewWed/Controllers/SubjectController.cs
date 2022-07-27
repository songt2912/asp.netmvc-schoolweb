using NewWed.Models;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWed.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ISubjectService _subjecttSevervice;

        public SubjectController(ISubjectService subjecttSevervice)
        {
             _subjecttSevervice= subjecttSevervice;
        }
        public ActionResult Index()
        {
            var s = _subjecttSevervice.GetSubject().Take(20);
            return View(s);
        }
        public ActionResult Create()
        {
            return View(new SubjectDto());

        }

        [HttpPost]
        public ActionResult Create(SubjectDto subject)
        {
            _subjecttSevervice.AddSubject(subject);
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int id)
        {
            return View(_subjecttSevervice.GetId(id));

        }

        [HttpPost]
        public ActionResult Edit(SubjectDto subject)
        {
            _subjecttSevervice.UpdateSubject(subject);
            return RedirectToAction("Index");

        }
        
        public ActionResult Delete(int id)
        {
            return View(_subjecttSevervice.GetId(id));

        }


        [HttpPost, ActionName("Delete")]
        public ActionResult Deletecomfi(int id)
        {
            _subjecttSevervice.DeleteSubject(id);

            return RedirectToAction("Index");

        }

    }
}
