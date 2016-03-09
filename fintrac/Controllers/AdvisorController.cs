using fintrac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace fintrac.Controllers
{
    public class AdvisorController : Controller
    {
        private MyDbContext db = new MyDbContext();
        //
        // GET: /Advisor/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Advisor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Advisor/Create
        public ActionResult RegisterAdvisor()
        {
            return View();
        }

        //
        // POST: /Advisor/Create
        [HttpPost]
        public ActionResult RegisterAdvisor(Advisor advisor)
        {
            try
            {
                // TODO: Add insert logic here
                db.Advisors.Add(advisor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Advisor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Advisor/Edit/5
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

        //
        // GET: /Advisor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Advisor/Delete/5
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
