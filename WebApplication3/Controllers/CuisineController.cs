using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Filters;

namespace WebApplication3.Controllers
{
    //[Authorize]
    public class CuisineController : Controller
    {
        // GET: Cuisine
       [Log]
        public ActionResult Search(string name="Chinese")
        {
            throw new Exception("Something terrible happened!");
            var message = Server.HtmlEncode(name);
            //return RedirectToRoute("Default", new { controller = "Home", action = "About"});
            //return File(Server.MapPath("~/Content/site.css"),"text/css");
            //return Json(new { Message = message, Name = "Kevin" }, JsonRequestBehavior.AllowGet);
            return Content(message);
        }
    }
}