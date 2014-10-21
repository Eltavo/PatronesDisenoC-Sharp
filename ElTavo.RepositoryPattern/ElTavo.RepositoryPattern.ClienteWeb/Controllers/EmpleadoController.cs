using System;
using ElTavo.RepositoryPattern.ApiRepository.DatosContacto;
using ElTavo.RepositoryPattern.Contrato;
using ElTavo.RepositoryPattern.SqlRepository.Empleado;
using System.Web.Mvc;
using Empleado = ElTavo.RepositoryPattern.Dominio.Empleado;

namespace ElTavo.RepositoryPattern.ClienteWeb.Controllers
{
    public class EmpleadoController : Controller
    {
        private IEmpleadoRepository empleadoRepository;

        // GET: Empleado
        public ActionResult Index()
        {
            empleadoRepository = new EmpleadoRepository();
            var empleados = empleadoRepository.ObtenerEmpleados();
            return View(empleados);
        }

        // GET: Empleado/Details/5
        public ActionResult Details(string id)
        {
            empleadoRepository = new EmpleadoRepository();
            var empleado = empleadoRepository.ObtenEmpleadoPoId(id.ToString());

            var datosRepository = new DatosContactoRepository();
            empleado.DatosContacto = datosRepository.ObtenerDatosContactoEmpleado(id.ToString());

            return View(empleado);
        }

        // POST: Empleado/Create
        [HttpPost]
        public ActionResult Create(Empleado model)
        {
            try
            {
                empleadoRepository = new EmpleadoRepository();
                model.Id = DateTime.Now.Ticks.ToString();
                empleadoRepository.GuardarEmpleado(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleado/Edit/5
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

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleado/Delete/5
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
