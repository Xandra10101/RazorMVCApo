using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorApp.Controllers
{
    public class ComicBookController : Controller
    {
        // GET: ComicBook
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ViewResult Details()
        {
            return View();
        }
    }
}