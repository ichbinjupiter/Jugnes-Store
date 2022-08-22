using JugnesStore.Filters;
using JugnesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JugnesStore.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class CategoryController : Controller
    {
        JugnesModel db = new JugnesModel();

        public ActionResult Index()
        {
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }

        [HttpGet]//Sayfa açılırken bu metot çalışır
        public ActionResult Create()
        {
            return View();
        }

        //Sayfada herhangi bir işlem yapıldığında Örn Butona Basıldığında bu metot çalışır
        [HttpPost]
        public ActionResult Create(Category c)
        {
            if (ModelState.IsValid)
            {
                db.Categories.Add(c);
                db.SaveChanges();
            }
            else
            {
                return View(c);
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Category c = db.Categories.Find(id);
            if (c == null)
            {
                return RedirectToAction("Index");
            }
            return View(c);
        }
        [HttpPost]
        public ActionResult Edit(Category c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                //Category old = db.Categories.Find(c.ID);
                //old.Isim = c.Isim;
                //old.Aciklama = c.Aciklama;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Category c = db.Categories.Find(id);
            if (c == null)
            {
                return RedirectToAction("Index");
            }
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}