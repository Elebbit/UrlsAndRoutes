using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlsAndRoutes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UrlsAndRoutes.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index() =>
            View("Result", new Result {Controller = nameof(HomeController), Action = nameof(Index)});

        public ViewResult CustomVariable(string id)
        {
            var r = new Result {Controller = nameof(HomeController), Action = nameof(CustomVariable)};

            r.Data["Id"] = id ?? "<no values>";
            return View("Result", r);
        }
    }
}
