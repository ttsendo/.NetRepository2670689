using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Donacione
{
    public int IdDonacion { get; set; }

    public int? IdDonante { get; set; }

    public string? TipoDonacion { get; set; }

    public string? Cantidad { get; set; }

    public string? Tipo { get; set; }

    public DateTime? FechaDonado { get; set; }

    public DateTime? FechaRegistroDonacion { get; set; }

    public virtual Donante? IdDonanteNavigation { get; set; }
}
