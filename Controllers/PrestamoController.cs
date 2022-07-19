using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ABONAP.Models;
using ABONAP.Models.Context;

namespace ABONAP.Controllers
{
    public class PrestamoController : Controller
    {
        private readonly AbonapContext _context;

        public PrestamoController(AbonapContext context)
        {
            _context = context;
        }

        // GET: Prestamo
        public async Task<IActionResult> Index()
        {
            var abonapContext = _context.Prestamos.Include(p => p.Cliente).Include(p => p.Sucursal);
            return View(await abonapContext.ToListAsync());
        }

        // GET: Prestamo/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Prestamos == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamos
                .Include(p => p.Cliente)
                .Include(p => p.Sucursal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // GET: Prestamo/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id");
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Id");
            return View();
        }

        // POST: Prestamo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClienteId,SucursalId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", prestamo.ClienteId);
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Id", prestamo.SucursalId);
            return View(prestamo);
        }

        // GET: Prestamo/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Prestamos == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", prestamo.ClienteId);
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Id", prestamo.SucursalId);
            return View(prestamo);
        }

        // POST: Prestamo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClienteId,SucursalId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Prestamo prestamo)
        {
            if (id != prestamo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrestamoExists(prestamo.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", prestamo.ClienteId);
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Id", prestamo.SucursalId);
            return View(prestamo);
        }

        // GET: Prestamo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Prestamos == null)
            {
                return NotFound();
            }

            var prestamo = await _context.Prestamos
                .Include(p => p.Cliente)
                .Include(p => p.Sucursal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // POST: Prestamo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Prestamos == null)
            {
                return Problem("Entity set 'AbonapContext.Prestamos'  is null.");
            }
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo != null)
            {
                _context.Prestamos.Remove(prestamo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrestamoExists(int id)
        {
          return (_context.Prestamos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
