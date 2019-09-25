using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookExamples.Areas.Chapter02.Controllers
{
    public class ch02DemosController : Controller
    {
        // GET: Chapter02/ch02Demos
        public ActionResult Index(string id)
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(id);
            }
            else
            {
                return View(id);
            }
        }
    }
}