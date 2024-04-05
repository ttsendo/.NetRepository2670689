using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class BajaMedicamento
{
    public int IdBajaMedicamento { get; set; }

    public int? IdMedicamento { get; set; }

    public DateTime? FechaBajaBaMedi { get; set; }

    public int? CantidadBaMedi { get; set; }

    public int? IdUsarioBaMedi { get; set; }

    public string? MotivoBaMed { get; set; }

    public virtual Medicamento? IdMedicamentoNavigation { get; set; }
}
