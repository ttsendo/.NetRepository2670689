using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Cita
{
    public int IdCita { get; set; }

    public int? IdUsuario { get; set; }

    public DateTime? FechaCita { get; set; }

    public string? EstadoCita { get; set; }

    public int? IdServicio { get; set; }

    public int? IdVoluntario { get; set; }

    public DateTime? FechaCreacionCita { get; set; }

    public DateTime? HoraCita { get; set; }

    public virtual Servicio? IdServicioNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ProfesionalesVoluntario? IdVoluntarioNavigation { get; set; }
}
