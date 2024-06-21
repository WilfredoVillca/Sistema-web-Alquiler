using Microsoft.AspNetCore.Mvc;
using SistemaWeb.Contexto;

namespace SistemaWeb.Controllers
{
    public class LoginController : Controller
    {
        MyContext _context;

        public LoginController(MyContext context)
        {
            //inyeccion de dependencias
            this._context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var usuario = _context.Usuarios
                .Where(x => x.Email == email)
                .Where(x => x.Password == password)
                .FirstOrDefault();

            if (usuario != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //mandando mensajes a la vista
                TempData["LoginError"] = "Cuenta o Password incorrectos!";
                return RedirectToAction("Index", "Login");
            }
        }

        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
