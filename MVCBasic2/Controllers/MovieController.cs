using MVCBasic2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic2.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            Movie m = new Movie()
            {

                Id = 3000,
                Name = "Avengers EndGame"

            };


            return View(m);
        }
    }
}