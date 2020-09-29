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
    }
}