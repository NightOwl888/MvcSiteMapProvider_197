using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSiteMapProvider;

namespace MvcSiteMapProvider_197.Controllers
{
    public class HomeController : Controller
    {
        [MvcSiteMapNode(Title="Home", Key="Home")]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [MvcSiteMapNode(Title = "About", Key = "About", ParentKey="Home")]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [MvcSiteMapNode(Title = "Contact", Key = "Contact", ParentKey = "Home")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
