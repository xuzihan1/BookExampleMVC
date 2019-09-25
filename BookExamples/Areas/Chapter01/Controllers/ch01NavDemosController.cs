using System.Web.Mvc;

namespace BookExamples.Areas.Chapter01.Controllers
{
    public class ch01NavDemosController : Controller
    {
        // GET
        public ActionResult Index(string id)
        {
            return View(id);
        }
    }
}