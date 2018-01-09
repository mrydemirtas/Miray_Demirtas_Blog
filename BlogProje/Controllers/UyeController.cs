using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogProje.Models;
using BlogProje.Models.Data;
using System.Data.Entity;

namespace BlogProje.Controllers
{
    
    public class UyeController : Controller
    {
        public object Uyes { get; private set; }

        // GET: Uye
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Uye uye)
        {
            BlogDB db = new BlogDB();
            var login = db.Uyes.Where(u => u.KullaniciAdi == uye.KullaniciAdi).SingleOrDefault();
            if (login.KullaniciAdi==uye.KullaniciAdi &&login.Email==uye.Email&&login.Sifre==uye.Sifre)
            {
                Session["uyeId"] = login.UyeId;
                Session["Kullaniciadi"] = login.KullaniciAdi;
                Session["yetkiId"] = login.YetkiId;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
            
        }
        public ActionResult LogOut()
        {
            Session["uyeId"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Uye uye,HttpPostedFile Foto)
        {
            return View();
        }
    }
}