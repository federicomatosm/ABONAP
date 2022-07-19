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
    public class SucursalController : Controller
    {
        private readonly AbonapContext _context;

        public SucursalController(AbonapContext context)
        {
            _context = context;
        }

        // GET: Sucursal
        public async Task<IActionResult> Index()
        {
            var abonapContext = _context.Sucursales.Include(s => s.Empresa);
            return View(await abonapContext.ToListAsync());
        }

        // GET: Sucursal/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Sucursales == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursales
                .Include(s => s.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sucursal == null)
            {
                return NotFound();
            }

            return View(sucursal);
        }

        // GET: Sucursal/Create
        public IActionResult Create()
        {
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Descripcion");
            return View();
        }

        // POST: Sucursal/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descripcion,EmpresaId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Sucursal sucursal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sucursal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Id", sucursal.EmpresaId);
            return View(sucursal);
        }

        // GET: Sucursal/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Sucursales == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursales.FindAsync(id);
            if (sucursal == null)
            {
                return NotFound();
            }
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Descripcion", sucursal.EmpresaId);
            return View(sucursal);
        }

        // POST: Sucursal/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descripcion,EmpresaId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Sucursal sucursal)
        {
            if (id != sucursal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sucursal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SucursalExists(sucursal.Id))
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
            ViewData["EmpresaId"] = new SelectList(_context.Empresas, "Id", "Descripcion", sucursal.EmpresaId);
            return View(sucursal);
        }

        // GET: Sucursal/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Sucursales == null)
            {
                return NotFound();
            }

            var sucursal = await _context.Sucursales
                .Include(s => s.Empresa)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sucursal == null)
            {
                return NotFound();
            }

            return View(sucursal);
        }

        // POST: Sucursal/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Sucursales == null)
            {
                return Problem("Entity set 'AbonapContext.Sucursales'  is null.");
            }
            var sucursal = await _context.Sucursales.FindAsync(id);
            if (sucursal != null)
            {
                _context.Sucursales.Remove(sucursal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SucursalExists(int id)
        {
          return (_context.Sucursales?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
