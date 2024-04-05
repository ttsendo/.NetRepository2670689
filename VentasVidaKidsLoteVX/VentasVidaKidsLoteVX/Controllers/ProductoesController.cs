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
    public class ProductoesController : Controller
    {
        private readonly VidaKidsLoteV4Context _context;

        public ProductoesController(VidaKidsLoteV4Context context)
        {
            _context = context;
        }

        // GET: Productoes
        public async Task<IActionResult> Index()
        {
            var vidaKidsLoteV4Context = _context.Productos.Include(p => p.NombreCategoriaNavigation).Include(p => p.NombreEstadoNavigation);
            return View(await vidaKidsLoteV4Context.ToListAsync());
        }

        // GET: Productoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.NombreCategoriaNavigation)
                .Include(p => p.NombreEstadoNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productoes/Create
        public IActionResult Create()
        {
            ViewData["NombreCategoria"] = new SelectList(_context.CategoriaProductos, "NombreCategoria", "NombreCategoria");
            ViewData["NombreEstado"] = new SelectList(_context.ProductosEstados, "NombreEstado", "NombreEstado");
            return View();
        }

        // POST: Productoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NombreEstado,NombreCategoria,IdProducto,NombreProducto,DescripcionProducto,PrecioProducto,Stock")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NombreCategoria"] = new SelectList(_context.CategoriaProductos, "NombreCategoria", "NombreCategoria", producto.NombreCategoria);
            ViewData["NombreEstado"] = new SelectList(_context.ProductosEstados, "NombreEstado", "NombreEstado", producto.NombreEstado);
            return View(producto);
        }

        // GET: Productoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["NombreCategoria"] = new SelectList(_context.CategoriaProductos, "NombreCategoria", "NombreCategoria", producto.NombreCategoria);
            ViewData["NombreEstado"] = new SelectList(_context.ProductosEstados, "NombreEstado", "NombreEstado", producto.NombreEstado);
            return View(producto);
        }

        // POST: Productoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NombreEstado,NombreCategoria,IdProducto,NombreProducto,DescripcionProducto,PrecioProducto,Stock")] Producto producto)
        {
            if (id != producto.IdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.IdProducto))
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
            ViewData["NombreCategoria"] = new SelectList(_context.CategoriaProductos, "NombreCategoria", "NombreCategoria", producto.NombreCategoria);
            ViewData["NombreEstado"] = new SelectList(_context.ProductosEstados, "NombreEstado", "NombreEstado", producto.NombreEstado);
            return View(producto);
        }

        // GET: Productoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Productos == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.NombreCategoriaNavigation)
                .Include(p => p.NombreEstadoNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Productos == null)
            {
                return Problem("Entity set 'VidaKidsLoteV4Context.Productos'  is null.");
            }
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
          return (_context.Productos?.Any(e => e.IdProducto == id)).GetValueOrDefault();
        }
    }
}
