using MathWeb.Models.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;


namespace MathWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home 
      
        MathDataContext db = new MathDataContext();

        public ActionResult Index()
        {
           
         
            return View();
        }
        

    }
}