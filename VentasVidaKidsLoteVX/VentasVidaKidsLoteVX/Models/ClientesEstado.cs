using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class ClientesEstado
{
    public int IdEstadoCliente { get; set; }

    public string NombreEstadoCliente { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; } = new List<Cliente>();
}
