using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class ProfesionalesVoluntario
{
    public int IdVoluntario { get; set; }

    public int? IdRol { get; set; }

    public int? IdUsuario { get; set; }

    public string? NombreProfesional { get; set; }

    public string? TipoDocumento { get; set; }

    public int? NumeroDocumento { get; set; }

    public string? EstadoVoluntario { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Cita> Cita { get; } = new List<Cita>();

    public virtual ICollection<DetalleProfesionalVoluntario> DetalleProfesionalVoluntarios { get; } = new List<DetalleProfesionalVoluntario>();

    public virtual Role? IdRolNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
