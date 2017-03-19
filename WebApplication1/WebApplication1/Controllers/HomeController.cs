using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            ViewData["rest"] = "test içerik";

            for (int i = 0; i <= 10; i++)
            {
                ViewData["rest"] += ViewData["rest"].ToString() + i.ToString();
            }

            try
            {
                int pi = 314;
                int sifir = 0;
                double sonuc = pi / sifir;
            }
            catch (Exception)
            {
                
                throw;
            }

            return View();
        }

        public ActionResult deneem()
        {
            return View();
        }
    }
}