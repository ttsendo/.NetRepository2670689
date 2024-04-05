using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class DetalleProfesionalVoluntario
{
    public int IdDetalleProfesionalVoluntario { get; set; }

    public int? IdVoluntario { get; set; }

    public int? IdTipoProfesional { get; set; }

    public int? IdTipoVoluntario { get; set; }

    public DateTime? FechaInicio { get; set; }

    public DateTime? FechaFinal { get; set; }

    public virtual ICollection<EncargadoVoluntario> EncargadoVoluntarios { get; } = new List<EncargadoVoluntario>();

    public virtual TipoProfesional? IdTipoProfesionalNavigation { get; set; }

    public virtual TipoVoluntario? IdTipoVoluntarioNavigation { get; set; }

    public virtual ProfesionalesVoluntario? IdVoluntarioNavigation { get; set; }
}
