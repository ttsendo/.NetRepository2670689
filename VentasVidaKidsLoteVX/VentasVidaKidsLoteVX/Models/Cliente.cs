using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Cliente
{
    public string? NombreEstadoCliente { get; set; }

    public int IdCliente { get; set; }

    public string? NombreCliente { get; set; }

    public string? ApellidoCliente { get; set; }

    public string? EmailCliente { get; set; }

    public long? TelefonoCliente { get; set; }

    public string? PaisCliente { get; set; }

    public string? CiudadCliente { get; set; }

    public string? PasswordCliente { get; set; }

    public DateTime? FechaClienteRegistro { get; set; }

    public virtual ClientesEstado? NombreEstadoClienteNavigation { get; set; }
}
