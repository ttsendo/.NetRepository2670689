using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class TipoVoluntario
{
    public int IdTipoVoluntario { get; set; }

    public string? NombreTipoVoluntario { get; set; }

    public virtual ICollection<DetalleProfesionalVoluntario> DetalleProfesionalVoluntarios { get; } = new List<DetalleProfesionalVoluntario>();
}
