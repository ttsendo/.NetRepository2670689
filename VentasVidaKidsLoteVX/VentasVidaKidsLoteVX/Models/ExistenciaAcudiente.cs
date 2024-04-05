using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class ExistenciaAcudiente
{
    public int IdExAc { get; set; }

    public int? IdBeneficiario { get; set; }

    public int? IdAcudiente { get; set; }

    public byte[] FechaInicioAcudiente { get; set; } = null!;

    public DateTime? FechaFinalAcudiente { get; set; }
}
