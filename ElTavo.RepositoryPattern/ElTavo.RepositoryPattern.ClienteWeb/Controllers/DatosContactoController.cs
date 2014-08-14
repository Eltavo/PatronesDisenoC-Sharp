using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElTavo.RepositoryPattern.ApiRepository.DatosContacto;

namespace ElTavo.RepositoryPattern.ClienteWeb.Controllers
{
    public class DatosContactoController : Controller
    {
        // GET: DatosContacto
        public ActionResult Index()
        {
            var datosContactoRepository = new DatosContactoRepository();
            var datosContacto = datosContactoRepository.ObtenerDatosContactoEmpleado("1");
            return View(datosContacto);
        }

        // GET: DatosContacto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DatosContacto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DatosContacto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DatosContacto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DatosContacto/Edit/5
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

        // GET: DatosContacto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DatosContacto/Delete/5
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
