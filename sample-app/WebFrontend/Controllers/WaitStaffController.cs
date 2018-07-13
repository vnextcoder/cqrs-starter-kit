using System;
using System.Collections.Generic;
using System.Linq;
using WebFrontEnd.ActionFilters;
using Microsoft.AspNetCore.Mvc;
namespace WebFrontEnd.Controllers
{
       [IncludeLayoutData]
    public class WaitStaffController : Controller
    {
        public ActionResult Todo(string id)
        {
            ViewBag.Waiter = id;
            return View(Domain.OpenTabQueries.TodoListForWaiter(id));
        }
    }
}
