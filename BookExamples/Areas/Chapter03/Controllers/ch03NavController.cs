﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookExamples.Areas.Chapter03.Controllers
{
    public class ch03NavController : Controller
    {
        // GET: Chapter03/ch03Nav
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                int a = 1;
                return PartialView();
            }
            else
            {
                int b = 2;
                return View();
            }
        }
    }
}