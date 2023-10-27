using MiniBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MiniBook.Controllers
{
    public class CategoryController : Controller
    {
        BOOKSTOREEntities db = new BOOKSTOREEntities();

        public ActionResult Index()//Làm thêm phân trang
        {
            if (Session["Admin"] == null)
                return RedirectToAction("Login", "Admin");
            var theLoaiSach = db.THELOAIs.ToList();
            return View(theLoaiSach);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(THELOAI tl)
        {
            try
            {
                db.THELOAIs.Add(tl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Có lỗi trong quá trình thêm thể loại");
            }
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var theLoaiSach = db.THELOAIs.Where(c => c.IDTheLoai == id).FirstOrDefault();
            if (theLoaiSach == null)
            {
                return HttpNotFound();
            }
            return View(theLoaiSach);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var theLoaiSach = db.THELOAIs.Where(c => c.IDTheLoai == id).FirstOrDefault();
                db.THELOAIs.Remove(theLoaiSach);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return Content("Không thể xóa vì có sản phẩm tồn tại");
            }
        }
    }
}