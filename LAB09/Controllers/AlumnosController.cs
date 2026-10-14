using LAB09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB09.Controllers
{
    public class AlumnosController : Controller
    {
        // Lista en memoria (static para que sobreviva entre peticiones)
        private static readonly List<Alumno> _alumnos = new();
        private static int _siguienteId = 1;

        private static readonly string[] _carreras =
        {
            "Ingeniería de Sistemas", "Administración", "Contabilidad", "Diseño Gráfico"
        };

        public IActionResult Index()
        {
            return View(_alumnos);
        }

        // GET: muestra el formulario vacío
        [HttpGet]
        public IActionResult Create()
        {
            CargarCarreras();
            return View(new Alumno());
        }

        // POST: el model binding crea el objeto Alumno con los datos del formulario
        [HttpPost]
        public IActionResult Create(Alumno alumno)
        {
            if (!ModelState.IsValid)
            {
                CargarCarreras(); // el SelectList no viaja en el POST, hay que volver a cargarlo
                return View(alumno);
            }

            alumno.Id = _siguienteId++; // el Id lo asigna el servidor, no se confía en el HiddenFor
            _alumnos.Add(alumno);
            return RedirectToAction(nameof(Confirmacion), new { id = alumno.Id });
        }

        public IActionResult Confirmacion(int id)
        {
            var alumno = _alumnos.FirstOrDefault(a => a.Id == id);
            if (alumno == null) return NotFound();
            return View(alumno);
        }

        // Para comparar Html.TextBox("Nombres") vs Html.TextBoxFor(m => m.Nombres)
        public IActionResult Comparar()
        {
            return View(new Alumno { Nombres = "Juan Perez" });
        }

        private void CargarCarreras()
        {
            ViewBag.Carreras = new SelectList(_carreras);
        }
    }
}
