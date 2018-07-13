
using Cafe.Tab;
using System.Text.RegularExpressions;
using WebFrontEnd.ActionFilters;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace WebFrontEnd.Controllers
{
   [IncludeLayoutData]
    public class ChefController : Controller
    {
        public ActionResult Index()
        {
            return View(Domain.ChefTodoListQueries.GetTodoList());
        }

        [HttpPost]
        public ActionResult MarkPrepared(Guid id, IFormCollection form)
        {
            Domain.Dispatcher.SendCommand(new MarkFoodPrepared
            {
                Id = id,
                MenuNumbers = (from entry in form.Keys.Cast<string>()
                               where form[entry] != "false"
                               let m = Regex.Match(entry, @"prepared_\d+_(\d+)")
                               where m.Success
                               select int.Parse(m.Groups[1].Value)
                              ).ToList()
            });

            return RedirectToAction("Index");
        }
    }
}
