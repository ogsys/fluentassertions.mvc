﻿using System.Web.Mvc;

namespace FluentAssertions.Mvc.Samples.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult List()
        {
            return View("Index");
        }
    }
}
