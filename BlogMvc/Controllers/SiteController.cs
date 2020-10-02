using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogMvc.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ViewResult Anasayfa()
        {
            return View();
        }
        public ViewResult CDersi()
        {
            return View();
        }
        public ViewResult Sql()
        {
            return View();
        }
        public ViewResult WebApi()
        {
            return View();
        }
    }
}