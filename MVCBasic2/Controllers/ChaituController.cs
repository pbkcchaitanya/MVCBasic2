using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic2.Controllers
{
    public class ChaituController : Controller
    {
        // GET: Chaitu
        public ActionResult Index()
        {
            return View();
        }
    }
}