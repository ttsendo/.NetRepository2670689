using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Participante
{
    public int IdParticipantes { get; set; }

    public int? IdEvento { get; set; }

    public int? IdUsuario { get; set; }

    public string? NombreParticipante { get; set; }

    public string? ApellidoParticipante { get; set; }

    public int? EdadParticipante { get; set; }

    public bool? AsistenciaParticipante { get; set; }

    public string? TipoDocumento { get; set; }

    public int? DocumentoParticipante { get; set; }

    public string? PlacaVehiculoPersonalParticipantes { get; set; }

    public virtual Evento? IdEventoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
