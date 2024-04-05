using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class HistoriaClínica
{
    public int IdHistoriaClinica { get; set; }

    public string? NombreBeneficiario { get; set; }

    public string? ApellidosBeneficiario { get; set; }

    public string? TipoDocumento { get; set; }

    public int? NroDocumento { get; set; }

    public string? NombreAcudiente { get; set; }

    public string? ApellidosAcudiente { get; set; }

    public string? TipoDocumentoAcudiente { get; set; }

    public int? NroDocumentoAcudiente { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
