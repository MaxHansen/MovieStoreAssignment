using Proxy.DomainModels;
using Proxy.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShopCustomer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Facade fac = new Facade();
            Movie mov = new Movie() { ID = 1, Title = "Title", price = 2020, Year = DateTime.Now };
            fac.GetMovieRepository().Add(mov);
            return View(fac.GetMovieRepository().GetAllMovies());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}