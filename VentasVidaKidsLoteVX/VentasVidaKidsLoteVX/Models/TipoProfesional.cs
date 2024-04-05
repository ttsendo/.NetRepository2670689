using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class TipoProfesional
{
    public int IdTipoProfesional { get; set; }

    public string? NombreTipoprofesional { get; set; }

    public virtual ICollection<DetalleProfesionalVoluntario> DetalleProfesionalVoluntarios { get; } = new List<DetalleProfesionalVoluntario>();
}
