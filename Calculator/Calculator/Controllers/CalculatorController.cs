using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calculator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculator/Create
        public ActionResult Calculate()
        {
            return View();
        }

        // POST: Calculator/Create
        [HttpPost]
        public ActionResult Calculate(Calculation c, FormCollection form)
        {
            string operation = form["operation"].ToString();
            try
            {
                if (ModelState.IsValid)
                {
                    if (operation.Equals("+"))
                        ViewBag.Result = c.Operand1 + c.Operand2;
                    if (operation.Equals("-"))
                        ViewBag.Result = c.Operand1 - c.Operand2;
                    if (operation.Equals("*"))
                        ViewBag.Result = c.Operand1 * c.Operand2;
                    if (operation.Equals("/"))
                        ViewBag.Result = c.Operand1 / c.Operand2;

                    return View();
                }
                return View(c);
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "Calculator", "Create"));
            }
        }

        // GET: Calculator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calculator/Edit/5
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

        // GET: Calculator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calculator/Delete/5
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
