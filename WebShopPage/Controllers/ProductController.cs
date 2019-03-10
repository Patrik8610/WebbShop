using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShopPage.Models;

namespace WebShopPage.Controllers
{
    public class ProductController : Controller
    {
		// visar upp produkterna i en ViewBag
		private webshopdbEntities2 web = new webshopdbEntities2();
        // GET: Product
        public ActionResult Index()
        {
			ViewBag.listProducts = web.Products.ToList();
            return View();
        }
    }
}