using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JugnesStore.Models;

namespace JugnesStore.Controllers
{
    public class HomeController : Controller
    {
        JugnesModel db = new JugnesModel();
        // GET: Home
        public ActionResult Index()
        {
            List<Product> ProductList = db.Products.Where(s => s.SellStatus == true).ToList();
            return View(ProductList);
        }
    }
}