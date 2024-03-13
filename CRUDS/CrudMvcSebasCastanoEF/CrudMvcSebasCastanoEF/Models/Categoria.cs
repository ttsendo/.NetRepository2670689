using System;
using System.Collections.Generic;

namespace CrudMvcSebasCastanoEF.Models;

public partial class Categoria
{
    public int CodigoCategoria { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Libro> Libros { get; } = new List<Libro>();
}
