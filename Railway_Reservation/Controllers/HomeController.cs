using Railway_Reservation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Railway_Reservation.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext(); 
   
        public ActionResult Index()
        {
            var data = db.Reservations.ToList();

            ViewBag.Title = "Home Page";

            return View(data);
        }
    }
}
