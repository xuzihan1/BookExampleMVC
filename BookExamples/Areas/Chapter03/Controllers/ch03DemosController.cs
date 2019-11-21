using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookExamples.Areas.Chapter03.Controllers
{
    public class ch03DemosController : Controller
    {
        // GET: Chapter03/ch03Demos
        public ActionResult Index(string id)
        {
            if (Request.IsAjaxRequest())
            {
                int a = 1;
                return PartialView(id);
            }
            else
            {
                int b = 2;
                return View(id);
            }
        }

        public ActionResult ContentResultDemo1()
        {
            string s = string.Format("返回结果:{0:HH:mm:ss}", DateTime.Now);
            return Content(s);
        }

        public ActionResult ContentResultDemo2()
        {
            string s = "alert('Hello')";
            return Content(s,"text/javascript");
        }

        public ActionResult JavaScriptResultDemo()
        {
            return JavaScript("alert('Hello')");
        }

        [HttpPost]
        public ActionResult JsonResultDemo1()
        {
            string s = string.Format("返回结果:{0:HH:mm:ss}", DateTime.Now);
            return Json(s);
        }

        public ActionResult FileResultDemo1()
        {
            var downloadFiles = File("/Areas/Chapter03/downloadFiles/a1.txt", "text/plain");
            return downloadFiles;
        }

        public ActionResult RedirectResultDemo()
        {
            string url = Url.Action("Index","ch03Demos",new {id = "ActionRendAction"});
            return Redirect(url);
        }

        public ActionResult ViewDataViewBag()
        {
            ViewData["Name"] = "张三";
            ViewBag.Name = "张三";

            List<string> myColors = new List<string>
            {
                "red,红色", "green,绿色", "blue,蓝色"
            };
            ViewData["MyColors"] = myColors;
            ViewBag.Mycolors = myColors;
            return PartialView();
        }
    }
}