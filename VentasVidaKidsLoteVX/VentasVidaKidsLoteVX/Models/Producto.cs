using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Producto
{
    public string? NombreEstado { get; set; }

    public string? NombreCategoria { get; set; }

    public int IdProducto { get; set; }

    public string? NombreProducto { get; set; }

    public string? DescripcionProducto { get; set; }

    public int? PrecioProducto { get; set; }

    public int? Stock { get; set; }

    public virtual CategoriaProducto? NombreCategoriaNavigation { get; set; }

    public virtual ProductosEstado? NombreEstadoNavigation { get; set; }
}
