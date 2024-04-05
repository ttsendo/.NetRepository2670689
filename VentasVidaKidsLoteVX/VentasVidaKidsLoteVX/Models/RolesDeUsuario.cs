using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class RolesDeUsuario
{
    public int IdRolUsuario { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRol { get; set; }

    public virtual Role? IdRolNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
