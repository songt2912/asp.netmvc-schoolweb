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
    public class SubjectScoreController : Controller
    {
        // GET: SubjectScore

        private readonly ISubjectScoreService _subjectScoreService;


        public SubjectScoreController(ISubjectScoreService subjectScoreService)
        {
             _subjectScoreService= subjectScoreService; ;
        }
        public ActionResult Index()
        {
            var s = _subjectScoreService.GetSubjectScore().Take(20);
            return View(s);
        }
        // add
        public ActionResult Create()
        {
            return View(new ExamScoreDto());
        }
        [HttpPost]
        public ActionResult Create(ExamScore subjectScoreDto)
        {
            _subjectScoreService.AddSubjectScore(subjectScoreDto);
            return RedirectToAction("Index");

        }
        //edit
        public ActionResult Edit(int id)
        {

            return View(_subjectScoreService.GetId(id));

        }

       [HttpPost]
        public ActionResult Edit(ExamScore subjectScore)
        {
            _subjectScoreService.UpdateSubjectScroce(subjectScore);

            return RedirectToAction("Index");

        }
        //delete
        public ActionResult Delete(int id)
        {

            return View(_subjectScoreService.GetId(id));

        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Deleteconfi(int id)
        {
            _subjectScoreService.DeleteSubjectScore(id);

            return RedirectToAction("Index");

        }


    }
}