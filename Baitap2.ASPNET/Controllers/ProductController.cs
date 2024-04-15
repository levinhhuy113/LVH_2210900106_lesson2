using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Baitap2.ASPNET.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowProduct()
        {
            return View();
        }
        public ActionResult EditProduct(int? productId)
        {
            ViewBag.id = productId;
            return View();
        }
        public ActionResult DetailsProduct(string productName,int? productId)
        {
            ViewBag.name = productName;
            ViewBag.id = productId;
            return View();
        }
    }
}