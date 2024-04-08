using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VentasVidaKidsLoteVX.Models;

namespace VentasVidaKidsLoteVX.Controllers
{
    public class CategoriaProductoesController : Controller
    {
        private readonly VidaKidsLoteV4Context _context;

        public CategoriaProductoesController(VidaKidsLoteV4Context context)
        {
            _context = context;
        }

   
        // GET: CategoriaProductoes
        public async Task<IActionResult> Index()
        {
              return _context.CategoriaProductos != null ? 
                          View(await _context.CategoriaProductos.ToListAsync()) :
                          Problem("Entity set 'VidaKidsLoteV4Context.CategoriaProductos'  is null.");
        }

        // GET: CategoriaProductoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CategoriaProductos == null)
            {
                return NotFound();
            }

            var categoriaProducto = await _context.CategoriaProductos
                .FirstOrDefaultAsync(m => m.NombreCategoria == id);
            if (categoriaProducto == null)
            {
                return NotFound();
            }

            return View(categoriaProducto);
        }

        // GET: CategoriaProductoes/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: CategoriaProductoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        // POST: CategoriaProductoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCategoria,NombreCategoria,DescripcionCategoria")] CategoriaProducto categoriaProducto)
        {
            // Verifica si ya existe una categoría con el mismo nombre
            var existingCategory = await _context.CategoriaProductos.FirstOrDefaultAsync(c => c.NombreCategoria == categoriaProducto.NombreCategoria);

            if (existingCategory != null)
            {
                // Si ya existe una categoría con el mismo nombre, muestra un mensaje de error
                ModelState.AddModelError("NombreCategoria", "Ya existe una categoría con este nombre.");
            }

            if (ModelState.IsValid)
            {
                // Si no hay errores de validación, procede a crear la nueva categoría
                _context.Add(categoriaProducto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Si hay errores de validación o si ya existe una categoría con el mismo nombre, muestra el formulario de creación nuevamente
            return View(categoriaProducto);
        }


        // GET: CategoriaProductoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CategoriaProductos == null)
            {
                return NotFound();
            }

            var categoriaProducto = await _context.CategoriaProductos.FindAsync(id);
            if (categoriaProducto == null)
            {
                return NotFound();
            }
            return View(categoriaProducto);
        }

        // POST: CategoriaProductoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdCategoria,NombreCategoria,DescripcionCategoria")] CategoriaProducto categoriaProducto)
        {
            if (id != categoriaProducto.NombreCategoria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoriaProducto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoriaProductoExists(categoriaProducto.NombreCategoria))
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
            return View(categoriaProducto);
        }

        // GET: CategoriaProductoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CategoriaProductos == null)
            {
                return NotFound();
            }

            var categoriaProducto = await _context.CategoriaProductos
                .FirstOrDefaultAsync(m => m.NombreCategoria == id);
            if (categoriaProducto == null)
            {
                return NotFound();
            }

            return View(categoriaProducto);
        }

        // POST: CategoriaProductoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CategoriaProductos == null)
            {
                return Problem("Entity set 'ServiciosDbContext.Categoria'  is null.");
            }

            var categorium = await _context.CategoriaProductos.FindAsync(id);

            if (categorium == null)
            {
                return NotFound();
            }

            // Verificar si la clave externa está siendo utilizada
            var isForeignKeyUsed = _context.CategoriaProductos.Any(s => s.IdCategoria == id);

            if (isForeignKeyUsed)
            {
                // Mostrar una alerta si la clave externa está siendo utilizada
                TempData["ErrorMessage"] = "No se puede eliminar la categoría porque está siendo utilizada por uno o más servicios.";
                return RedirectToAction(nameof(Index));
            }
            else if (categorium != null)
            {


                // Agregar la alerta de éxito a TempData
                TempData["SuccessMessage"] = "La categoría se eliminó correctamente.";
            }

            // Si la clave externa no está siendo utilizada, eliminar la categoría
            _context.CategoriaProductos.Remove(categorium);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CategoriaProductos == null)
            {
                return Problem("Entity set 'VidaKidsLoteV4Context.CategoriaProductos'  is null.");
            }
            var categoriaProducto = await _context.CategoriaProductos.FindAsync(id);
            if (categoriaProducto != null)
            {
                _context.CategoriaProductos.Remove(categoriaProducto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriaProductoExists(string id)
        {
          return (_context.CategoriaProductos?.Any(e => e.NombreCategoria == id)).GetValueOrDefault();
        }
    }
}
