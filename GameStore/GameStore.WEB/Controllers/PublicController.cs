using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.WEB.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public
        public ActionResult Main()
        {
            return View();
        }

        // GET: Public/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Public/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Public/Create
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

        // GET: Public/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Public/Edit/5
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

        // GET: Public/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Public/Delete/5
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