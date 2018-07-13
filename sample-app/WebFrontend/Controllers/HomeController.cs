using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebFrontEnd.ActionFilters;

namespace WebFrontEnd.Controllers
{
    [IncludeLayoutData]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
