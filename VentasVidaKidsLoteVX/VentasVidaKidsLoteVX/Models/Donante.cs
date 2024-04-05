using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Donante
{
    public int IdDonante { get; set; }

    public int? IdRol { get; set; }

    public int? IdUsuario { get; set; }

    public string? NombreDonante { get; set; }

    public string? ApellidosDonante { get; set; }

    public string? DireccionDonante { get; set; }

    public string? TelefonoDonante { get; set; }

    public string? EmailDonante { get; set; }

    public string? TipoDonante { get; set; }

    public string? DocumentoDonante { get; set; }

    public DateTime? FechaRegistroD { get; set; }

    public string? EntidadAsociada { get; set; }

    public virtual ICollection<Donacione> Donaciones { get; } = new List<Donacione>();

    public virtual Role? IdRolNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
