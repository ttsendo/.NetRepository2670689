using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public int? IdRol { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Estado { get; set; }

    public string? CorreoElectronico { get; set; }

    public string? ContraseñaUsuario { get; set; }

    public virtual Acudiente? Acudiente { get; set; }

    public virtual ICollection<Cita> Cita { get; } = new List<Cita>();

    public virtual ICollection<Donante> Donantes { get; } = new List<Donante>();

    public virtual Role? IdRolNavigation { get; set; }

    public virtual ICollection<Participante> Participantes { get; } = new List<Participante>();

    public virtual ICollection<ProfesionalesVoluntario> ProfesionalesVoluntarios { get; } = new List<ProfesionalesVoluntario>();

    public virtual ICollection<RolesDeUsuario> RolesDeUsuarios { get; } = new List<RolesDeUsuario>();
}
