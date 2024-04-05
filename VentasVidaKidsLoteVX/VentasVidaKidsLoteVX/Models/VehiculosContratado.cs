using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class VehiculosContratado
{
    public int IdVc { get; set; }

    public int? IdEvento { get; set; }

    public string? TipoVc { get; set; }

    public int? CapacidadVc { get; set; }

    public string? PlacaVc { get; set; }

    public virtual Evento? IdEventoNavigation { get; set; }
}
