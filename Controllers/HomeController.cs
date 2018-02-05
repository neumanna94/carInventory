using Microsoft.AspNetCore.Mvc;
using CarInventory.Models;
using System.Collections.Generic;

namespace CarInventory.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
          return View();
        }

        [Route("/result")]
        public ActionResult Result()
        {
            Car newCar = new Car();
            newCar.SetMake(Request.Query["make"]);
            newCar.SetDate(Request.Query["year"]);
            newCar.SetCost(Request.Query["cost"]);
            newCar.PushToList(newCar);
            return View("Result", newCar);
        }
        [Route("/")]
        public ActionResult Fo
      }
}
