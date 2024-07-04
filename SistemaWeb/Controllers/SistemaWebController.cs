using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaWeb.Contexto;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{
    public class SistemaWebController : Controller
    {
        private readonly MyContext _context;
        public SistemaWebController(MyContext context)
        {
            _context = context;
        }
        // GET: SistemaWebController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SistemaWebController/Details/5
        public ActionResult Ubicacion(int id)
        {
            return View();
        }




        // GET: SistemaWebController/Create
        public ActionResult Creates()
        {
            return View();
        }


        // POST: SistemaWebController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Creates(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        
        }

        // GET: SistemaWebController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SistemaWebController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SistemaWebController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SistemaWebController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
