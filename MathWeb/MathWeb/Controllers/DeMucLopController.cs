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

        [HttpPost]
        public ActionResult Search(FormCollection f)
        {
           string name = f["query"].ToString();
           ViewBag.DeMucLop = (from x in db.DeMucLops
                      where x.TenDeMuc.Contains(name)
                      select x).ToList();

            ViewBag.BaiViet = (from x in db.BaiViets
                                where x.TenBaiViet.Contains(name)
                                select x).ToList();

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


        public JsonResult Navigate(string id,string navigate)
        {
            int iddemuc = int.Parse(id);
            DeMucLop result = null;
            if (navigate=="back")
            {
                try
                {
                     result = db.DeMucLops.Where(x => x.ID == iddemuc - 1).FirstOrDefault();
                    if (result==null)
                    {
                        result = db.DeMucLops.Where(x => x.ID == iddemuc).FirstOrDefault();
                    }
                  
                }
                catch 
                {
                     result = db.DeMucLops.Where(x => x.ID == iddemuc).FirstOrDefault();

                }
            }
            else
            {
                try
                {
                    result = db.DeMucLops.Where(x => x.ID == iddemuc + 1).FirstOrDefault();
                    if (result == null)
                    {
                        result = db.DeMucLops.Where(x => x.ID == iddemuc).FirstOrDefault();
                    }

                }
                catch
                {
                     result = db.DeMucLops.Where(x => x.ID == iddemuc).FirstOrDefault();

                }
            }

            //id= ViewBag.IDDeMuc
           

            return Json(new {
                ID=result.ID,
                IDLop = result.IDLop,
                TenDeMuc=result.TenDeMuc
            }, JsonRequestBehavior.AllowGet);
        }
    }
}