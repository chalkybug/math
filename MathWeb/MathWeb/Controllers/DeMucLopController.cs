using MathWeb.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathWeb.Controllers
{
    public class DeMucLopController : Controller
    {
        // GET: DeMucLop
        MathDataContext db = new MathDataContext();
        public ActionResult Index()
        {
            return View();
        }

        
        public JsonResult getDeMucLop()
        {

            List<DeMucLop> result = db.DeMucLops.ToList();
            var demuclop = result.Select(x => new {
                ID = x.ID,
                TenDeMuc = x.TenDeMuc,
                IDLop = x.IDLop
            });
            return Json(demuclop, JsonRequestBehavior.AllowGet);
        }
    }
}