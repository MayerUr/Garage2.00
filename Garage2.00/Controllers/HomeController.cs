﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garage2._00.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "FALCON GARAGE AB";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "FALCON GARAGE AB";

            return View();
        }
    }
}