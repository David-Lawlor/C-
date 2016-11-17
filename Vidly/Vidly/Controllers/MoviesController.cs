using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Views.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        // Passing to view through the view method
//        // GET: Movies
//        public ActionResult Random()
//        {
//            var movie = new Movie() { Name = "Shrek"};
//            return View(movie);
//        }


        // Using a dictionary to send data into the view
//        // GET: Movies
//        public ActionResult Random()
//        {
//            var movie = new Movie() { Name = "Shrek" };
//            ViewData["Movie"] = movie;
//
//            return View();
//        }


//        // Using the viewbag the send data to the view
//        // GET: Movies
//        public ActionResult Random()
//        {
//            var movie = new Movie() { Name = "Shrek" };
//            ViewBag.Movie = movie;
//
//            return View();
//        }

        // Using the ViewModel the send data to the view
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortby))
                sortby = "Name";

            return Content(string.Format("pageIndex={0}&sortby={1}", pageIndex, sortby));
        }

        // defining the route. the month has a regex which constrains it to 2 digits and
        // the range defines the range of possible values
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

        }
    }
}