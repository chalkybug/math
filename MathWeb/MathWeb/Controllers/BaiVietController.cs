using MathWeb.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathWeb.Controllers
{
    public class BaiVietController : Controller
    {
        // GET: BaiViet
        MathDataContext db = new MathDataContext();

        public ActionResult Show(int id)
        {
            var baivets = db.BaiViets.Where(x => x.IDDeMuc == id).ToList();
            ViewBag.TenDeMuc = db.DeMucLops.Where(x => x.ID == id).FirstOrDefault().TenDeMuc;

            return View(baivets);
        }

        public ActionResult Detail(int id)
        {
            var baivet = db.BaiViets.Where(x => x.ID == id).FirstOrDefault() ;

            ViewBag.TenBaiViet = baivet.TenBaiViet;
            ViewBag.LinkBaiViet = baivet.LinkVideo;
            return View(baivet);
        }


        public JsonResult GetBaiVietJson(int id)
        {
            List<BaiViet> baivet = db.BaiViets.Where(x => x.IDDeMuc == id).ToList();

            var result = baivet.Select(x => new {
                ID = x.ID,
                TenBaiViet = x.TenBaiViet,
                Data = x.Data,
                LinkVideo = x.LinkVideo,
                IDDeMuc = x.IDDeMuc,
              
            });
            

            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetBaiVietByBaiVietJson(int id)
        {
            var idDeMucLop = db.BaiViets.Where(x => x.ID == id).FirstOrDefault().IDDeMuc;

            List<BaiViet> baivet = db.BaiViets.Where(x => x.IDDeMuc == idDeMucLop).ToList();

            var result = baivet.Select(x => new {
                ID = x.ID,
                TenBaiViet = x.TenBaiViet,
                Data = x.Data,
                LinkVideo = x.LinkVideo,
                IDDeMuc = x.IDDeMuc,

            });


            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}