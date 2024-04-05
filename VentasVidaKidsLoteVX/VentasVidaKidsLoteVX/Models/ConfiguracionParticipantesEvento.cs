using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class ConfiguracionParticipantesEvento
{
    public int IdConfigEvento { get; set; }

    public int? IdEvento { get; set; }

    public string? TipoUsuarioCpe { get; set; }

    public string? GeneroBiologicoCpe { get; set; }

    public int? RangoEdadMinCpe { get; set; }

    public int? RangoEdadMaxCpe { get; set; }

    public int? CantidadInvitadosPorGenero { get; set; }

    public virtual Evento? IdEventoNavigation { get; set; }
}
