using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1Asp.Models;

namespace Lab1Asp.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index()
        {
            return View(new Car{ Make = "Toyota", EngineSize = 1600, EngineType = EngineType.Diesel, Model = "Avensis"});
        }
    }
}