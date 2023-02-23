using Microsoft.AspNetCore.Mvc;
using WebSelfMedx.Models;

namespace WebSelfMedx.Controllers
{
    public class MedicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


       /* [HttpPost]
        public IActionResult Create(Usuario newUsuario, Medico newMedico)
        {

            


            SelfmedixContext _context = new SelfmedixContext();
            Usuario newUsuario = new Usuario
            {
                Apellidos = collection.Select(a => a.Apellidos),
            };
            _context.Usuarios.Add(newUsuario);
            _context.SaveChanges();
        }*/
    }



}

