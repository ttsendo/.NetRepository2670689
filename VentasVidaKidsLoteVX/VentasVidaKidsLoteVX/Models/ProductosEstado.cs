using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class ProductosEstado
{
    public int IdEstadoProductos { get; set; }

    public string NombreEstado { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; } = new List<Producto>();
}
