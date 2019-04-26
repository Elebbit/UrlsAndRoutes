using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;


namespace UrlsAndRoutes.Controllers
{
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index() => View("Result",
            new Result { Controller = nameof(CustomerController), Action = nameof(Index)});

        public ViewResult List(string id)
        {
            var r = new Result {Controller = nameof(CustomerController), Action = nameof(List)};

            r.Data["id"] = id ?? "<no value>";
            r.Data["catchall"] = RouteData.Values["catchall"];
            return View("Result", r);
        }
    } 
}
