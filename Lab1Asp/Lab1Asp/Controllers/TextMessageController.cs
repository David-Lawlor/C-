using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1Asp.Models;

namespace Lab1Asp.Controllers
{
    public class TextMessageController : Controller
    {
        // GET: TextMessage
        public ActionResult Index()
        {
            return View();
        }

        // GET: TextMessage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TextMessage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TextMessage/Create
        [HttpPost]
        public ActionResult Create(TextMessage tm)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Show", tm);
            }
            catch
            {
                return View();
            }
        }

        // GET: TextMessage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TextMessage/Edit/5
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

        // GET: TextMessage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TextMessage/Delete/5
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

        public ActionResult Show(TextMessage tm)
        {
            return View(tm);
        }
    }
}
