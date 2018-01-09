using BlogProje.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            BlogDB db = new BlogDB();
            //Tüm makalelerimizi, tarih sırasına göre, büyükten küçüğe olmak üzere çekiyoruz.
            List<Makale> makaleListe = (from i in db.Makales orderby i.Tarih descending select i).ToList();
         
            return View(makaleListe);

        }
        public ActionResult Create()
        {
            BlogDB db = new BlogDB();

            ViewBag.KategoriId = new SelectList(db.Kategoris, "KategoriId", "KategoriAdi");
            return View();
         
        }
            
        
    }
}