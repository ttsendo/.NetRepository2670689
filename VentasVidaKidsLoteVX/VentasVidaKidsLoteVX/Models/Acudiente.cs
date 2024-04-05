using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Acudiente
{
    public int IdUsuario { get; set; }

    public int IdAcudiente { get; set; }

    public int? IdRol { get; set; }

    public string? TipoDocumento { get; set; }

    public string? DocumetoIdentidadAcu { get; set; }

    public string? NombreAcudiente { get; set; }

    public string? ApellidosAcudiente { get; set; }

    public DateTime? FechaNacimientoAcudiente { get; set; }

    public string? EstadoAcudiente { get; set; }

    public string? ParentescoAcudiente { get; set; }

    public string? TelefonoAcudiente { get; set; }

    public string? DirecciónAcudiente { get; set; }

    public string? CiudadBarrioAcudiente { get; set; }

    public virtual Role? IdRolNavigation { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
