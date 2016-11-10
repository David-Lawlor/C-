using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorldPart2.Models;

namespace HelloWorldPart2.Controllers
{
    public class HelloWorldPart2Controller : Controller
    {
        // GET: HelloWorldPart2
        public ActionResult Index(User user)
        {
            return View(user);
        }

        // GET: HelloWorldPart2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HelloWorldPart2/Create
        public ActionResult Welcome()
        {
            return View();
        }

        // POST: HelloWorldPart2/Create
        [HttpPost]
        public ActionResult Welcome(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index", user);
                }
                return View(user);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "HelloWorldPart2", "Welcome"));
            }
        }

        // GET: HelloWorldPart2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HelloWorldPart2/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HelloWorldPart2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HelloWorldPart2/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
