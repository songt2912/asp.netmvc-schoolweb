using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Native;
using NewWed.Models;
using NewWed.Report;
using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWed.Controllers
{
    public class AllTableController : Controller
    {
        // GET: AllTable
        private readonly IAllTable _AllService;
        public static IEnumerable<AlltableDto> all= new List<AlltableDto>(); 

        public AllTableController(IAllTable AllService)
        {
            _AllService = AllService;
        }

        public ActionResult Index(string studentName, string className, string subjectName, string roles4student)
        {
            var s = _AllService.GetAll().Distinct().ToList();

            ViewBag.className = new SelectList(s, "ClassName", "ClassName");
             var e = _AllService.GetSubject().Distinct();
            ViewBag.subjectName = new SelectList(e, "SubjectName", "SubjectName");
            var i = _AllService.GetAll().Distinct();
            var search = _AllService.Seachingbarforschool(studentName, className, subjectName, roles4student);
            var view = _AllService.GetTop10().Take(10);
            if (!string.IsNullOrEmpty(studentName)|| !string.IsNullOrEmpty(className)|| !string.IsNullOrEmpty(subjectName)|| !string.IsNullOrEmpty(roles4student))
            {

                all = _AllService.Seachingbarforschool(studentName, className, subjectName, roles4student);
                return View(all);

            }
            
            return View(view);

            //XtraReport1 rpt = new XtraReport1();
            //rpt.DataSource = search;


            //if (option == "Subject")
            //{
            //    var i = _AllService.SeachbySubject(seachString);
            //    return View(i);

            //}
            //else if (!string.IsNullOrEmpty(classname) )
            //{
            //    var i = _AllService.GetByScoreRole().Where(x => x.ClassName == classname);
            //    return View(i);

            //}

            //    //name
            //    if (!string.IsNullOrEmpty(seachString))
            //    {
            //        view = view.Where(x => x.StudentName == seachString);

            //    }
            //    //name-role


            //    //class
            //    if (!string.IsNullOrEmpty(classname))
            //    {

            //        view = view.Where(x => x.ClassName == classname);
            //    }
            ////subject
            //    if (!string.IsNullOrEmpty(subject))
            //    {
            //    view = view.Where(x => x.SubjectName  == subject);

            //    }
            ////rol

            //    if (Role == "Giỏi")
            //    {
            //        var i = _AllService.ClassificationAll().Where(X => X.Roles == Role);
            //        ViewBag.Roles = i;
            //        return View(i);

            //    }
            //    else if (Role == "Khá")
            //    {
            //        var i = _AllService.ClassificationAll().Where(X => X.Roles == Role);
            //        ViewBag.Roles = i;
            //        return View(i);
            //    }
            //    else if (Role == "Trung bình")
            //    {
            //        var i = _AllService.ClassificationAll().Where(X => X.Roles == Role);
            //        ViewBag.Roles = i;
            //        return View(i);
            //    }
            //    else if (Role == "Yếu")
            //    {
            //        var i = _AllService.ClassificationAll().Where(X => X.Roles == Role);
            //        ViewBag.Roles = i;
            //        return View(i);
            //    }
            //    if (Role == "Tất cả" && string.IsNullOrEmpty(subject) && string.IsNullOrEmpty(classname) && string.IsNullOrEmpty(classname))
            //    {
            //    var i = _AllService.GetTop10().ToList();
            //    return View(i);
            //}
            //subject
            //}
            //else if ((Role=="Tất Cả"&& classname=="") || (Role == "Tất Cả" && string.IsNullOrEmpty(seachString)))
            //{
            //    var i = _AllService.GetTop10().ToList();

            //    return View(i);
            //}

            //else {
            //    var i = _AllService.GetAll().ToList();

            //    return View(i);

            //}
            //SchoolReport context = new SchoolReport();
            //context.DataSource = search;
            
            
        }
        public ActionResult PrintPDF(string studentName="", string className="", string subjectName="", string roles4student="")
        {

            
                SchoolReport rp = new SchoolReport();

                rp.DataSource = all;

                //Response.Buffer = false;
                //Response.Buffer = false;
                //Response.ClearContent();
                //Response.ClearHeaders();

                //rp.DesignerOptions.

                var stream = new MemoryStream();
                rp.ExportToPdf(stream);

                var cd = new System.Net.Mime.ContentDisposition
                {
                    FileName = "asp-nettest.pdf",
                    Inline = false,
                };
                Response.AppendHeader("Content-Disposition", cd.ToString());
                
            
            return File(stream.ToArray(), "application/pdf");
        }
        //public ActionResult PrintPDF()
        //{
        //    //SchoolReport context = new SchoolReport();
        //    //context.DataSource = search;

        //    return new PartialViewAsPdf("_JobPrint", Data)
        //    {
        //        FileName = "TestPartialViewAsPdf.pdf"
        //    };
        //}
        //[HttpPost, ActionName("Index")]
        //public ActionResult IndexC(string GetType, string seachString)
        //{



        //    else
        //    {
        //        var i = _AllService.GetByScoreRole(seachString);
        //        ViewBag.Roles = i;
        //        return View(i);

        //    }


        //}
    }
}