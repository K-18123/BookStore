using Microsoft.Ajax.Utilities;
using MiniBook.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniBook.Controllers
{
    public class MBookController : Controller
    {
        BOOKSTOREEntities db = new BOOKSTOREEntities();
        // GET: MBook
        private List<SACH> TopSaleBooks(int soluong)
        {
            return db.SACHes.OrderByDescending(sach =>sach.SLBan).Take(soluong).ToList();
        }

        public ActionResult Index()
        {
            var sp = TopSaleBooks(4);
            return View(sp);
        }
        public ActionResult AllBook()
        {
            return View(db.SACHes.OrderByDescending(sach => sach.NgayPhatHanh).ToList());
        }
    }
}