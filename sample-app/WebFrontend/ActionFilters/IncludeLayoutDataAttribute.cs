using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebFrontEnd.ActionFilters
{
    public class IncludeLayoutDataAttribute : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.Result is ViewResult)
            {
                var viewdata = (filterContext.Result as ViewResult).ViewData;


                viewdata.Add("WaitStaff", StaticData.WaitStaff);
                viewdata.Add("ActiveTables",Domain.OpenTabQueries.ActiveTableNumbers());
               
            }
        }
    }
}