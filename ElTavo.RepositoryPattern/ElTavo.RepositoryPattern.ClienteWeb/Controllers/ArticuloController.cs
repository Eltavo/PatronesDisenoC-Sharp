using ElTavo.RepositoryPattern.Contrato;
using ElTavo.RepositoryPattern.MongoRepository.Articulo;
using System.Web.Mvc;
using Articulo = ElTavo.RepositoryPattern.Dominio.Articulo;

namespace ElTavo.RepositoryPattern.ClienteWeb.Controllers
{
    public class ArticuloController : Controller
    {
        private IArticuloRepository _articuloRepository;

        // GET: Articulo
        public ActionResult Index()
        {
            _articuloRepository = new ArticuloRepository();
            var articulos = _articuloRepository.ObtenerArticulos();
            return View(articulos);
        }

        // GET: Articulo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Articulo/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Articulo model)
        {
            try
            {
                _articuloRepository = new ArticuloRepository();
                _articuloRepository.GuardarArticulo(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Articulo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Articulo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Articulo/Edit/5
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

        // GET: Articulo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Articulo/Delete/5
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
