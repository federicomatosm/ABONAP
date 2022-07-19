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
    public class DocumentoController : Controller
    {
        private readonly AbonapContext _context;

        public DocumentoController(AbonapContext context)
        {
            _context = context;
        }

        // GET: Documento
        public async Task<IActionResult> Index()
        {
            var abonapContext = _context.Documentos.Include(d => d.TipoDocumento);
            return View(await abonapContext.ToListAsync());
        }

        // GET: Documento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Documentos == null)
            {
                return NotFound();
            }

            var documento = await _context.Documentos
                .Include(d => d.TipoDocumento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documento == null)
            {
                return NotFound();
            }

            return View(documento);
        }

        // GET: Documento/Create
        public IActionResult Create()
        {
            ViewData["TipoDocumentoId"] = new SelectList(_context.TipoDocumentos, "Id", "Descripcion");
            return View();
        }

        // POST: Documento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descripcion,TipoDocumentoId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Documento documento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(documento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoDocumentoId"] = new SelectList(_context.TipoDocumentos, "Id", "Id", documento.TipoDocumentoId);
            return View(documento);
        }

        // GET: Documento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Documentos == null)
            {
                return NotFound();
            }

            var documento = await _context.Documentos.FindAsync(id);
            if (documento == null)
            {
                return NotFound();
            }
            ViewData["TipoDocumentoId"] = new SelectList(_context.TipoDocumentos, "Id", "Descripcion", documento.TipoDocumentoId);
            return View(documento);
        }

        // POST: Documento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descripcion,TipoDocumentoId,Id,FechaCreacion,FechaActualizacion,Codigo,Estado")] Documento documento)
        {
            if (id != documento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(documento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DocumentoExists(documento.Id))
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
            ViewData["TipoDocumentoId"] = new SelectList(_context.TipoDocumentos, "Id", "Descripcion", documento.TipoDocumentoId);
            return View(documento);
        }

        // GET: Documento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Documentos == null)
            {
                return NotFound();
            }

            var documento = await _context.Documentos
                .Include(d => d.TipoDocumento)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (documento == null)
            {
                return NotFound();
            }

            return View(documento);
        }

        // POST: Documento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Documentos == null)
            {
                return Problem("Entity set 'AbonapContext.Documentos'  is null.");
            }
            var documento = await _context.Documentos.FindAsync(id);
            if (documento != null)
            {
                _context.Documentos.Remove(documento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DocumentoExists(int id)
        {
          return (_context.Documentos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
