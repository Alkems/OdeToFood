using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OdeToFood.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        public IActionResult Search(string name = "unknown")
        {
            var message = HtmlEncoder.Default.Encode(name);
            //throw new Exception("Something terrible has happened");

            return Content(message);
            //return Content(message);
            //return new EmptyResult();
            //return File("/css/site.css", "text/css")
            //return Json(HtmlEncoder.Default);
            //return Redirect("https://www.tthk.ee");
            //TODO Miks ei tööta? return RedirectToRoute("default", new { controller = "cuisine", action = "Second", count = 5 });
            //TODO Miks ei tööta? return RedirectToRoute(nameof(Second), new { count = 5 });
            //return RedirectToRoute("default", new { controller = "Home" }, Action = "About"});
        }
        public IActionResult Second(int count)
        {
            return Content($"Teine on siin! {count}");
        }
    }
}

