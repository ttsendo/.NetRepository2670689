using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudMvcSebasCastanoEF.Models;

namespace CrudMvcSebasCastanoEF.Controllers
{
    public class EditorialesController : Controller
    {
        private readonly BibliotecaContext _context;

        public EditorialesController(BibliotecaContext context)
        {
            _context = context;
        }

        // GET: Editoriales
        public async Task<IActionResult> Index(string buscar, string filtro)
        {
            var editoriales = from Editoriale in _context.Editoriales select Editoriale;

            if (!String.IsNullOrEmpty(buscar))
            {
                editoriales = editoriales.Where(s => s.Nombres!.Contains(buscar));
            }
            ViewData["FiltroNombre"] = String.IsNullOrEmpty(filtro) ?    "NombreDescendente" : "";
            ViewData["FiltroTelefono"] = filtro == "TelefonoAscendente" ? "TelefonoDescendente" : "TelefonoAscendente";


            switch (filtro)
            {
                case "NombreDescendente":
                    editoriales = editoriales.OrderByDescending(editoriales => editoriales.Nombres);
                    break;
                case "TelefonoDescendente":
                    editoriales = editoriales.OrderByDescending(editoriales => editoriales.Telefono);
                    break;
                case "TelefonoAscendente":
                    editoriales = editoriales.OrderBy(editoriales => editoriales.Telefono);
                    break;
                default:
                    editoriales = editoriales.OrderBy(editoriales => editoriales.Nombres);
                   // editoriales = editoriales.OrderBy(editoriales => editoriales.Telefono);
                    break;

            }

            return View(await editoriales.ToListAsync());
        }

        // GET: Editoriales/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Editoriales == null)
            {
                return NotFound();
            }

            var editoriale = await _context.Editoriales
                .FirstOrDefaultAsync(m => m.Nit == id);
            if (editoriale == null)
            {
                return NotFound();
            }

            return View(editoriale);
        }

        // GET: Editoriales/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Editoriales/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nit,Nombres,Telefono,Direccion,Email,Sitioweb")] Editoriale editoriale)
        {
            if (ModelState.IsValid)
            {
                _context.Add(editoriale);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(editoriale);
        }

        // GET: Editoriales/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Editoriales == null)
            {
                return NotFound();
            }

            var editoriale = await _context.Editoriales.FindAsync(id);
            if (editoriale == null)
            {
                return NotFound();
            }
            return View(editoriale);
        }

        // POST: Editoriales/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Nit,Nombres,Telefono,Direccion,Email,Sitioweb")] Editoriale editoriale)
        {
            if (id != editoriale.Nit)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(editoriale);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EditorialeExists(editoriale.Nit))
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
            return View(editoriale);
        }

        // GET: Editoriales/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Editoriales == null)
            {
                return NotFound();
            }

            var editoriale = await _context.Editoriales
                .FirstOrDefaultAsync(m => m.Nit == id);
            if (editoriale == null)
            {
                return NotFound();
            }

            return View(editoriale);
        }

        // POST: Editoriales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Editoriales == null)
            {
                return Problem("Entity set 'BibliotecaContext.Editoriales'  is null.");
            }
            var editoriale = await _context.Editoriales.FindAsync(id);
            if (editoriale != null)
            {
                _context.Editoriales.Remove(editoriale);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EditorialeExists(int id)
        {
          return (_context.Editoriales?.Any(e => e.Nit == id)).GetValueOrDefault();
        }
    }
}
