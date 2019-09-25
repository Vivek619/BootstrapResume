using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace new2_21Aug.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public FileResult download()
        {
            string file = @"~\Content\Resume\Resume.docx";
            string contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            return File(file, contentType, Path.GetFileName(file));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}