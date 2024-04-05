using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Role
{
    public int IdRol { get; set; }

    public string? Rol { get; set; }

    public virtual ICollection<Acudiente> Acudientes { get; } = new List<Acudiente>();

    public virtual ICollection<Donante> Donantes { get; } = new List<Donante>();

    public virtual ICollection<ProfesionalesVoluntario> ProfesionalesVoluntarios { get; } = new List<ProfesionalesVoluntario>();

    public virtual ICollection<RolesDeUsuario> RolesDeUsuarios { get; } = new List<RolesDeUsuario>();

    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
