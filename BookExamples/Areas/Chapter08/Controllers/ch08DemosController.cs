﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookExamples.Areas.Chapter08.cs;
using BookExamples.Areas.Chapter08.Models.MyDb2Model;

namespace BookExamples.Areas.Chapter08.Controllers
{
    public class ch08DemosController : Controller
    {
        // GET: Chapter08/ch08Demos
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

        public ActionResult InitMyDb2()
        {
            MyDb2 db = new MyDb2();
            MyDb2InitAlways context = new MyDb2InitAlways();
            context.InitializeDatabase(db);
            ViewBag.Count1 = db.MyTable1.Count();
            ViewBag.Count2 = db.MyTable2.Count();
            ViewBag.Count3 = db.MyTable3.Count();
            return PartialView();
        }
    }
}