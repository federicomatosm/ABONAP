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
    public class DepartamentoController : Controller
    {
        private readonly AbonapContext _context;

        public DepartamentoController(AbonapContext context)
        {
            _context = context;
        }

        // GET: Departamento
        public async Task<IActionResult> Index()
        {
            var abonapContext = _context.Departamentos.Include(d => d.Sucursal);
            return View(await abonapContext.ToListAsync());
        }

        // GET: Departamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos
                .Include(d => d.Sucursal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // GET: Departamento/Create
        public IActionResult Create()
        {
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Descripcion");
            return View();
        }

        // POST: Departamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descripcion,SucursalId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                departamento.FechaActualizacion = DateTime.Now;
                departamento.FechaCreacion = DateTime.Now;
                _context.Add(departamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            

            ViewData["SucursalId"]  = new SelectList(_context.Sucursales, "Id", "Id");
            return View(departamento);
        }

        // GET: Departamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento == null)
            {
                return NotFound();
            }
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Descripcion", departamento.SucursalId);
            return View(departamento);
        }

        // POST: Departamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descripcion,SucursalId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Departamento departamento)
        {
            if (id != departamento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartamentoExists(departamento.Id))
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
            ViewData["SucursalId"] = new SelectList(_context.Sucursales, "Id", "Id", departamento.SucursalId);
            return View(departamento);
        }

        // GET: Departamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Departamentos == null)
            {
                return NotFound();
            }

            var departamento = await _context.Departamentos
                .Include(d => d.Sucursal)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (departamento == null)
            {
                return NotFound();
            }

            return View(departamento);
        }

        // POST: Departamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Departamentos == null)
            {
                return Problem("Entity set 'AbonapContext.Departamentos'  is null.");
            }
            var departamento = await _context.Departamentos.FindAsync(id);
            if (departamento != null)
            {
                _context.Departamentos.Remove(departamento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartamentoExists(int id)
        {
          return (_context.Departamentos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
