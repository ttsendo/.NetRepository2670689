using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string? NombreServicio { get; set; }

    public DateTime? FechaRegistroServicio { get; set; }

    public bool? DisponibilidadServicio { get; set; }

    public int? IdCategoriaServicio { get; set; }

    public virtual ICollection<Cita> Cita { get; } = new List<Cita>();

    public virtual CategoriaServicio? IdCategoriaServicioNavigation { get; set; }
}
