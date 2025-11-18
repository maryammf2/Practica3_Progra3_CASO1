using Caso1_GestionLibros.Data;
using Caso1_GestionLibros.Models;
using Microsoft.AspNetCore.Mvc;

namespace Caso1_GestionLibros.Controllers
{
    public class LibroController : Controller
    {
        private readonly LibroRepository _repository;

        public LibroController()
        {
            _repository = new LibroRepository();
        }

        public IActionResult Index()
        {
            var libros = _repository.ObtenerLibros();
            return View(libros);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Libros libro)
        {
            // Validación de código interno único
            if (_repository.ExisteCodigoInterno(libro.CodigoInterno))
            {
                ModelState.AddModelError("CodigoInterno", "El código interno ya existe. Debe ser único.");
            }

            if (ModelState.IsValid)
            {
                _repository.AgregarLibro(libro);
                TempData["MensajeExito"] = "Libro agregado correctamente.";
                return RedirectToAction("Index");
            }

            return View(libro);
        }

    } //class
} //end

