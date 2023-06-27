using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheRideYouRent.Models;

namespace TheRideYouRent.Controllers
{
    public class RentalController : Controller
    {
        // GET: Rental
        public ActionResult Index()
        {
            return View();
        }
    }
}