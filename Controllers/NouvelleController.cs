using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectMohan.Controllers
{
    public class NouvelleController : Controller
    {
        // GET: Nouvelle
        public ActionResult Index()
        {
            return View();
        }

        // GET: Nouvelle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nouvelle/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nouvelle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Nouvelle/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Nouvelle/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Nouvelle/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Nouvelle/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}