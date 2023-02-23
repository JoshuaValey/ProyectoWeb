using Microsoft.AspNetCore.Mvc;
using WebSelfMedx.Models;

namespace WebSelfMedx.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            SelfmedixContext _context = new SelfmedixContext();
            return View(_context.Usuarios.ToList());

        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Crear(Usuario usuario)
        {
           
            SelfmedixContext _context = new SelfmedixContext();
            Usuario newUsuario = new Usuario
            {

                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Contrasenia = usuario.Contrasenia,
                FechaNacimiento = usuario.FechaNacimiento,
                FechaCreacion = DateTime.Now,
                
            };
            _context.Usuarios.Add(newUsuario);
            _context.SaveChanges();
                
            return View();  
        }

        [HttpGet]

        [Route("User/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            SelfmedixContext _context = new SelfmedixContext();
         
            _context.Usuarios.Remove(_context.Usuarios.Find(id));
            _context.SaveChanges();
            return RedirectToAction ("Index");
        }

        [HttpGet]
        [Route("User/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            SelfmedixContext _context = new SelfmedixContext();
            return View(_context.Usuarios.Find(id));
        }



        [HttpPost]
        public IActionResult Edit(Usuario usuario)
        {

            SelfmedixContext _context = new SelfmedixContext();
            Usuario newUsuario = new Usuario
            {

                Nombres = usuario.Nombres,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Contrasenia = usuario.Contrasenia,
                FechaNacimiento = usuario.FechaNacimiento,
                FechaCreacion = DateTime.Now,

            };
            _context.Usuarios.Update(newUsuario);
            _context.SaveChanges();

            return View();
        }



    }
}
