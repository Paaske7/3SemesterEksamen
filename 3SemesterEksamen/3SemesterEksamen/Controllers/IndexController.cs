using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3SemesterEksamen.Models;


namespace _3SemesterEksamen.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(Index poll)
        {
            poll.URL = "http://localhost:59124/Index/Next"; 
            if (ModelState.IsValid)
            {
                return View("URL", poll);
            }
            else
            {
                return View();
            }
            
        }
        [HttpPost]
        public ViewResult URL(Index poll)
        {
            if (ModelState.IsValid)
            {
                return View("Result", poll);
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult Result()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Result(Index poll)
        {    
            return View(); 
        }

      

    }
}