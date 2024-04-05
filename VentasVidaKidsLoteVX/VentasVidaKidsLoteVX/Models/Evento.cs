using System;
using System.Collections.Generic;

namespace VentasVidaKidsLoteVX.Models;

public partial class Evento
{
    public int IdEvento { get; set; }

    public string? NombreEvento { get; set; }

    public DateTime? FechaHoraEvento { get; set; }

    public string? EstadoEvento { get; set; }

    public string? EmpresaEvento { get; set; }

    public string? EncargadoEmpresaEvento { get; set; }

    public int? TelefonoEncargadoEmpresaEvento { get; set; }

    public string? LugarRealizacionEvento { get; set; }

    public int? NumeroInvitados { get; set; }

    public virtual ICollection<ConfiguracionParticipantesEvento> ConfiguracionParticipantesEventos { get; } = new List<ConfiguracionParticipantesEvento>();

    public virtual ICollection<Participante> Participantes { get; } = new List<Participante>();

    public virtual ICollection<VehiculosContratado> VehiculosContratados { get; } = new List<VehiculosContratado>();
}
