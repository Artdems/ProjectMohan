using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectMohan.BD;
using ProjectMohan.ViewModel.Nouvelles;

namespace ProjectMohan.Controllers
{
    public class NouvellesController : Controller
    {
        // GET: Nouvelle

        DAL dal = new DAL();
        public ActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();

            viewModel.nouvelle = dal.GetNouvelles();
            return View(viewModel);
        }

        // GET: Nouvelle/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Nouvelle/Create
        public ActionResult Create()
        {
            //CreateEditeNouvelleViewModel viewmodel = new CreateEditeNouvelleViewModel();
            //viewmodel.Action = "Create";
            //return View("CreateEditeNouvelle",viewmodel);
            string embed = "<object data=\"{0}\" type=\"application/pdf\" width=\"500px\" height=\"300px\">";
            embed += "If you are unable to view file, you can download from <a href = \"{0}\">here</a>";
            embed += " or download <a target = \"_blank\" href = \"http://get.adobe.com/reader/\">Adobe PDF Reader</a> to view the file.";
            embed += "</object>";
            TempData["Embed"] = string.Format(embed, "~/pdf/test.pdf");

            return View("CreateEditeNouvelle");
        }

        // POST: Nouvelle/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {

            try
            {
                dal.AjouterNouvelle(Request.Form["Titre"], Request.Form["Texte"]);
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