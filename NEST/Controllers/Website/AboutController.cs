﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEST.Models;

namespace NEST.Controllers
{
    public class AboutController : Controller
    {
        private NESTV1Entities db = new NESTV1Entities();

        public ActionResult Index(int id = 21)
        {
            try
            {
                ContentBody contentbody = db.ContentBodies.Single(c => c.Id == id);
                return View(contentbody);
            }
            catch
            {
                return View();

            }
        }

    }
}
