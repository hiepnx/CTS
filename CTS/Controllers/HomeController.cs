﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CTS.Domain.Domain;

namespace CTS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            CTSDbContext ct = new CTSDbContext();
            var a = ct.BugCategories.FirstOrDefault();
            return View();
        }

    }
}