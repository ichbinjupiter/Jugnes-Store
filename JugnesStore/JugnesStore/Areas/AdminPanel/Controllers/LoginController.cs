using JugnesStore.Models;
using JugnesStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JugnesStore.Areas.AdminPanel.Controllers
{
    public class LoginController : Controller
    {
        JugnesModel db = new JugnesModel();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ManagerViewModels model)
        {
            if (ModelState.IsValid)
            {
                int sayi = db.Managers.Count(s => s.Email == model.Mail && s.Password == model.Password);
                if (sayi > 0)
                {
                    Manager m = db.Managers.First(s => s.Email == model.Mail && s.Password == model.Password);
                    Session["manager"] = m;
                    return RedirectToAction("Index", "Product");
                }
            }
            return View(model);
        }
    }
}