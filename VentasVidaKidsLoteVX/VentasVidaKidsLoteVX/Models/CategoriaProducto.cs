using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class CategoriaProducto
{
    public int IdCategoria { get; set; }

    public string NombreCategoria { get; set; } = null!;

    public string? DescripcionCategoria { get; set; }

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
