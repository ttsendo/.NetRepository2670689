using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Medicamento
{
    public int IdMedicamento { get; set; }

    public string? NombreMedicamento { get; set; }

    public int? StockMedicamento { get; set; }

    public string? TipoCantidad { get; set; }

    public int? NumeroGramage { get; set; }

    public string? Gramage { get; set; }

    public virtual ICollection<BajaMedicamento> BajaMedicamentos { get; } = new List<BajaMedicamento>();
}
