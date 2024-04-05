using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class EncargadoVoluntario
{
    public int IdEncargadoVoluntario { get; set; }

    public int? IdDetalleProfesionalVoluntario { get; set; }

    public int? IdVoluntarioEncargado { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinal { get; set; }

    public virtual DetalleProfesionalVoluntario? IdDetalleProfesionalVoluntarioNavigation { get; set; }
}
