using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaWeb.Contexto;
using SistemaWeb.Models;

namespace SistemaWeb.Controllers
{
    public class AlquilerController : Controller
    {
        private readonly MyContext _context;

        public AlquilerController(MyContext context)
        {
            _context = context;
        }

        // GET: Alquiler
        public async Task<IActionResult> Index()
        {
            var myContext = _context.Alquilers.Include(a => a.Cancha).Include(a => a.Cliente).Include(a => a.Usuario);
            return View(await myContext.ToListAsync());
        }

        // GET: Alquiler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquiler = await _context.Alquilers
                .Include(a => a.Cancha)
                .Include(a => a.Cliente)
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alquiler == null)
            {
                return NotFound();
            }

            return View(alquiler);
        }

        // GET: Alquiler/Create
        public IActionResult Create()
        {
            ViewData["CanchaId"] = new SelectList(_context.Canchas, "Id", "Id");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Ci");
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email");
            return View();
        }

        // POST: Alquiler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero_Recibo,Fecha,Cantidad_Hora,Desde,Hasta,Costo_Total,UsuarioId,ClienteId,CanchaId")] Alquiler alquiler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alquiler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanchaId"] = new SelectList(_context.Canchas, "Id", "Id", alquiler.CanchaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Ci", alquiler.ClienteId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", alquiler.UsuarioId);
            return View(alquiler);
        }

        // GET: Alquiler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquiler = await _context.Alquilers.FindAsync(id);
            if (alquiler == null)
            {
                return NotFound();
            }
            ViewData["CanchaId"] = new SelectList(_context.Canchas, "Id", "Id", alquiler.CanchaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Ci", alquiler.ClienteId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", alquiler.UsuarioId);
            return View(alquiler);
        }

        // POST: Alquiler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero_Recibo,Fecha,Cantidad_Hora,Desde,Hasta,Costo_Total,UsuarioId,ClienteId,CanchaId")] Alquiler alquiler)
        {
            if (id != alquiler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alquiler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlquilerExists(alquiler.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CanchaId"] = new SelectList(_context.Canchas, "Id", "Id", alquiler.CanchaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Ci", alquiler.ClienteId);
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "Id", "Email", alquiler.UsuarioId);
            return View(alquiler);
        }

        // GET: Alquiler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alquiler = await _context.Alquilers
                .Include(a => a.Cancha)
                .Include(a => a.Cliente)
                .Include(a => a.Usuario)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (alquiler == null)
            {
                return NotFound();
            }

            return View(alquiler);
        }

        // POST: Alquiler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Alquilers == null)
            {
                return Problem("Entity set 'MiContext.Alquilers'  is null.");
            }
                var alquiler = await _context.Alquilers.FindAsync(id);
            if (alquiler != null)
            {
                _context.Alquilers.Remove(alquiler);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlquilerExists(int id)
        {
            return _context.Alquilers.Any(e => e.Id == id);
        }
    }
}
