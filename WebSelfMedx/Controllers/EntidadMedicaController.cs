using Microsoft.AspNetCore.Mvc;
using WebSelfMedx.Models;

namespace WebSelfMedx.Controllers
{
    public class EntidadMedicaController : Controller
    {
        public IActionResult Index()
        {
            SelfmedixContext _context = new SelfmedixContext();
            return View(_context.Entidadmedicas.ToList());
        }


        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Entidadmedica entidad)
        {
            SelfmedixContext _context = new SelfmedixContext();
            Entidadmedica newEntidad = new Entidadmedica
            {
                Nombre = entidad.Nombre,
                Direccion = entidad.Direccion
            };
            _context.Entidadmedicas.Add(newEntidad);
            _context.SaveChanges();

            return View();
        }

        [HttpGet]

        [Route("EntidadMedica/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            SelfmedixContext _context = new SelfmedixContext();

            _context.Entidadmedicas.Remove(_context.Entidadmedicas.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("EntidadMedica/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            SelfmedixContext _context = new SelfmedixContext();
            return View(_context.Entidadmedicas.Find(id));
        }



        [HttpPost]
        public IActionResult Edit(Entidadmedica entidad)
        {

            SelfmedixContext _context = new SelfmedixContext();
            Entidadmedica newEntidad = new Entidadmedica
            {
                Id = entidad.Id,
                Nombre = entidad.Nombre,
                Direccion = entidad.Direccion
            };
            _context.Entidadmedicas.Update(newEntidad);
            _context.SaveChanges();

            return View();
        }



    }
}
