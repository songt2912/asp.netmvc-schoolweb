using NewWed.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewWed.Controllers
{
    public class ClassRoomController : Controller
    {
        // GET: ClassRoom
        private  IClassRoomService _classRoomService;


        public ClassRoomController(IClassRoomService classRoomService)
        {
            _classRoomService = classRoomService;
        }
        public ActionResult Index()
        {
            var classroom = _classRoomService.GetClassRoom();
            return View(classroom);
        }
        


    }
}