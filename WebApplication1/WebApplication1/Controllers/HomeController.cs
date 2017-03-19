using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using WebApplication1.Models;

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

            deneme model = new deneme(); 
            ViewData["rest"] = "test içerik";

            for (int i = 0; i <= 10; i++)
            {
                ViewData["rest"] += ViewData["rest"].ToString() + i.ToString();
            }


            TempData["trk"] = "";

            DataTable dt = new DataTable();

            model.liste = dt.AsEnumerable().ToList();
            

            return View(model);
        }

        public ActionResult deneem()
        {
            return View();
        }
    }
}