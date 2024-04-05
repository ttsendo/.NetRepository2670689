using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class CategoriaServicio
{
    public int IdCategoriaServicio { get; set; }

    public string? NombreCategoriaServicio { get; set; }

    public DateTime? FechaRegistroCategoriaServicio { get; set; }

    public bool? DisponibilidadCategoriaServicio { get; set; }

    public virtual ICollection<Servicio> Servicios { get; } = new List<Servicio>();
}
