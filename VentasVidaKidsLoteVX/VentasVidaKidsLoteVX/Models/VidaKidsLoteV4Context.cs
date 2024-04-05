using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace VentasVidaKidsLoteVX.Models;

public partial class VidaKidsLoteV4Context : DbContext
{
    public VidaKidsLoteV4Context()
    {
    }

    public VidaKidsLoteV4Context(DbContextOptions<VidaKidsLoteV4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Acudiente> Acudientes { get; set; }

    public virtual DbSet<BajaMedicamento> BajaMedicamentos { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<CategoriaServicio> CategoriaServicios { get; set; }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClientesEstado> ClientesEstados { get; set; }

    public virtual DbSet<ConfiguracionParticipantesEvento> ConfiguracionParticipantesEventos { get; set; }

    public virtual DbSet<DetalleProfesionalVoluntario> DetalleProfesionalVoluntarios { get; set; }

    public virtual DbSet<Donacione> Donaciones { get; set; }

    public virtual DbSet<Donante> Donantes { get; set; }

    public virtual DbSet<EncargadoVoluntario> EncargadoVoluntarios { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<ExistenciaAcudiente> ExistenciaAcudientes { get; set; }

    public virtual DbSet<HistoriaClínica> HistoriaClínicas { get; set; }

    public virtual DbSet<Medicamento> Medicamentos { get; set; }

    public virtual DbSet<Participante> Participantes { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosEstado> ProductosEstados { get; set; }

    public virtual DbSet<ProfesionalesVoluntario> ProfesionalesVoluntarios { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolesDeUsuario> RolesDeUsuarios { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<TipoProfesional> TipoProfesionals { get; set; }

    public virtual DbSet<TipoVoluntario> TipoVoluntarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VehiculosContratado> VehiculosContratados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source= DESKTOP-T4NF6V5;Initial Catalog=VidaKidsLoteV4;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Acudiente>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Acudient__EF59F762A1E13469");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("Id_usuario");
            entity.Property(e => e.ApellidosAcudiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Apellidos_Acudiente");
            entity.Property(e => e.CiudadBarrioAcudiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Ciudad_Barrio_Acudiente");
            entity.Property(e => e.DirecciónAcudiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Dirección_Acudiente");
            entity.Property(e => e.DocumetoIdentidadAcu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Documeto_identidad_Acu");
            entity.Property(e => e.EstadoAcudiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Estado_Acudiente");
            entity.Property(e => e.FechaNacimientoAcudiente)
                .HasColumnType("date")
                .HasColumnName("Fecha_nacimiento_Acudiente");
            entity.Property(e => e.IdAcudiente)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_acudiente");
            entity.Property(e => e.IdRol).HasColumnName("Id_rol");
            entity.Property(e => e.NombreAcudiente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Nombre_Acudiente");
            entity.Property(e => e.ParentescoAcudiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Parentesco_Acudiente");
            entity.Property(e => e.TelefonoAcudiente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Telefono_Acudiente");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Tipo_Documento");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Acudientes)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Acudiente__Id_ro__04E4BC85");

            entity.HasOne(d => d.IdUsuarioNavigation).WithOne(p => p.Acudiente)
                .HasForeignKey<Acudiente>(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Acudiente__Id_us__05D8E0BE");
        });

        modelBuilder.Entity<BajaMedicamento>(entity =>
        {
            entity.HasKey(e => e.IdBajaMedicamento).HasName("PK__Baja_Med__0F317A0F7BCF7DBF");

            entity.ToTable("Baja_Medicamentos");

            entity.Property(e => e.IdBajaMedicamento).HasColumnName("Id_baja_Medicamento");
            entity.Property(e => e.CantidadBaMedi).HasColumnName("Cantidad_Ba_Medi");
            entity.Property(e => e.FechaBajaBaMedi)
                .HasColumnType("date")
                .HasColumnName("Fecha_Baja_Ba_Medi");
            entity.Property(e => e.IdMedicamento).HasColumnName("Id_Medicamento");
            entity.Property(e => e.IdUsarioBaMedi).HasColumnName("Id_Usario_Ba_Medi");
            entity.Property(e => e.MotivoBaMed)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Motivo_Ba_Med");

            entity.HasOne(d => d.IdMedicamentoNavigation).WithMany(p => p.BajaMedicamentos)
                .HasForeignKey(d => d.IdMedicamento)
                .HasConstraintName("FK__Baja_Medi__Id_Me__0C85DE4D");
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.HasKey(e => e.NombreCategoria).HasName("PK__Categori__64005BADF0461CF2");

            entity.ToTable("Categoria_Productos");

            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_Categoria");
            entity.Property(e => e.DescripcionCategoria)
                .HasMaxLength(125)
                .IsUnicode(false)
                .HasColumnName("descripcion_Categoria");
            entity.Property(e => e.IdCategoria)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_Categoria");
        });

        modelBuilder.Entity<CategoriaServicio>(entity =>
        {
            entity.HasKey(e => e.IdCategoriaServicio).HasName("PK__Categori__76FFB88871988F20");

            entity.ToTable("Categoria_servicios");

            entity.Property(e => e.IdCategoriaServicio).HasColumnName("Id_categoria_servicio");
            entity.Property(e => e.DisponibilidadCategoriaServicio).HasColumnName("Disponibilidad_categoria_servicio");
            entity.Property(e => e.FechaRegistroCategoriaServicio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro_categoria_servicio");
            entity.Property(e => e.NombreCategoriaServicio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_categoria_servicio");
        });

        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.IdCita).HasName("PK__Citas__5E31E3700F78C51F");

            entity.Property(e => e.IdCita).HasColumnName("Id_cita");
            entity.Property(e => e.EstadoCita)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_cita");
            entity.Property(e => e.FechaCita)
                .HasColumnType("date")
                .HasColumnName("Fecha_cita");
            entity.Property(e => e.FechaCreacionCita)
                .HasColumnType("date")
                .HasColumnName("Fecha_creacion_cita");
            entity.Property(e => e.HoraCita)
                .HasColumnType("date")
                .HasColumnName("hora_cita");
            entity.Property(e => e.IdServicio).HasColumnName("Id_servicio");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.IdVoluntario).HasColumnName("Id_voluntario");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK__Citas__Id_servic__71D1E811");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Citas__Id_usuari__70DDC3D8");

            entity.HasOne(d => d.IdVoluntarioNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdVoluntario)
                .HasConstraintName("FK__Citas__Id_volunt__72C60C4A");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__378C70542FF2DFD9");

            entity.Property(e => e.IdCliente).HasColumnName("id_Cliente");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("apellido_Cliente");
            entity.Property(e => e.CiudadCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ciudad_Cliente");
            entity.Property(e => e.EmailCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email_Cliente");
            entity.Property(e => e.FechaClienteRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_Cliente_Registro");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_Cliente");
            entity.Property(e => e.NombreEstadoCliente)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_Estado_Cliente");
            entity.Property(e => e.PaisCliente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pais_Cliente");
            entity.Property(e => e.PasswordCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("password_Cliente");
            entity.Property(e => e.TelefonoCliente).HasColumnName("telefono_Cliente");

            entity.HasOne(d => d.NombreEstadoClienteNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.NombreEstadoCliente)
                .HasConstraintName("FK__Clientes__fecha___1F98B2C1");
        });

        modelBuilder.Entity<ClientesEstado>(entity =>
        {
            entity.HasKey(e => e.NombreEstadoCliente).HasName("PK__Clientes__4817619DA0B2CFFF");

            entity.ToTable("Clientes_Estados");

            entity.Property(e => e.NombreEstadoCliente)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_Estado_Cliente");
            entity.Property(e => e.IdEstadoCliente)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_Estado_Cliente");
        });

        modelBuilder.Entity<ConfiguracionParticipantesEvento>(entity =>
        {
            entity.HasKey(e => e.IdConfigEvento).HasName("PK__Configur__D4D8DC69D7A45438");

            entity.ToTable("Configuracion_participantes_eventos");

            entity.Property(e => e.IdConfigEvento).HasColumnName("Id_config_evento");
            entity.Property(e => e.CantidadInvitadosPorGenero).HasColumnName("Cantidad_invitados_por_genero");
            entity.Property(e => e.GeneroBiologicoCpe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Genero_biologico_cpe");
            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.RangoEdadMaxCpe).HasColumnName("Rango_edad_max_cpe");
            entity.Property(e => e.RangoEdadMinCpe).HasColumnName("Rango_edad_min_cpe");
            entity.Property(e => e.TipoUsuarioCpe)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_usuario_cpe");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.ConfiguracionParticipantesEventos)
                .HasForeignKey(d => d.IdEvento)
                .HasConstraintName("FK__Configura__Id_ev__52593CB8");
        });

        modelBuilder.Entity<DetalleProfesionalVoluntario>(entity =>
        {
            entity.HasKey(e => e.IdDetalleProfesionalVoluntario).HasName("PK__Detalle___6D287F76CAF615EA");

            entity.ToTable("Detalle_profesional_voluntario");

            entity.Property(e => e.IdDetalleProfesionalVoluntario).HasColumnName("Id_detalle_profesional_voluntario");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_final");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_inicio");
            entity.Property(e => e.IdTipoProfesional).HasColumnName("Id_tipo_profesional");
            entity.Property(e => e.IdTipoVoluntario).HasColumnName("Id_tipo_voluntario");
            entity.Property(e => e.IdVoluntario).HasColumnName("Id_voluntario");

            entity.HasOne(d => d.IdTipoProfesionalNavigation).WithMany(p => p.DetalleProfesionalVoluntarios)
                .HasForeignKey(d => d.IdTipoProfesional)
                .HasConstraintName("FK__Detalle_p__Id_ti__66603565");

            entity.HasOne(d => d.IdTipoVoluntarioNavigation).WithMany(p => p.DetalleProfesionalVoluntarios)
                .HasForeignKey(d => d.IdTipoVoluntario)
                .HasConstraintName("FK__Detalle_p__Id_ti__6754599E");

            entity.HasOne(d => d.IdVoluntarioNavigation).WithMany(p => p.DetalleProfesionalVoluntarios)
                .HasForeignKey(d => d.IdVoluntario)
                .HasConstraintName("FK__Detalle_p__Id_vo__656C112C");
        });

        modelBuilder.Entity<Donacione>(entity =>
        {
            entity.HasKey(e => e.IdDonacion).HasName("PK__Donacion__5EB5C79BDD6DB838");

            entity.Property(e => e.IdDonacion).HasColumnName("Id_donacion");
            entity.Property(e => e.Cantidad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FechaDonado)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_Donado");
            entity.Property(e => e.FechaRegistroDonacion)
                .HasColumnType("date")
                .HasColumnName("Fecha_registro_donacion");
            entity.Property(e => e.IdDonante).HasColumnName("Id_donante");
            entity.Property(e => e.Tipo)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TipoDonacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("Tipo_donacion");

            entity.HasOne(d => d.IdDonanteNavigation).WithMany(p => p.Donaciones)
                .HasForeignKey(d => d.IdDonante)
                .HasConstraintName("FK__Donacione__Id_do__02084FDA");
        });

        modelBuilder.Entity<Donante>(entity =>
        {
            entity.HasKey(e => e.IdDonante).HasName("PK__Donantes__64269EC598F0E25C");

            entity.HasIndex(e => e.DocumentoDonante, "UQ__Donantes__52235C2A7D370C3E").IsUnique();

            entity.HasIndex(e => e.EmailDonante, "UQ__Donantes__582912B10EA635BB").IsUnique();

            entity.HasIndex(e => e.TelefonoDonante, "UQ__Donantes__70DFE3354CCEBF4E").IsUnique();

            entity.Property(e => e.IdDonante).HasColumnName("Id_donante");
            entity.Property(e => e.ApellidosDonante)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Apellidos_donante");
            entity.Property(e => e.DireccionDonante)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Direccion_donante");
            entity.Property(e => e.DocumentoDonante)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Documento_donante");
            entity.Property(e => e.EmailDonante)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Email_donante");
            entity.Property(e => e.EntidadAsociada)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Entidad_asociada");
            entity.Property(e => e.FechaRegistroD)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro_D");
            entity.Property(e => e.IdRol).HasColumnName("Id_rol");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.NombreDonante)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Nombre_donante");
            entity.Property(e => e.TelefonoDonante)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Telefono_donante");
            entity.Property(e => e.TipoDonante)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Tipo_donante");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Donantes)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Donantes__Id_rol__7D439ABD");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Donantes)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Donantes__Id_usu__7E37BEF6");
        });

        modelBuilder.Entity<EncargadoVoluntario>(entity =>
        {
            entity.HasKey(e => e.IdEncargadoVoluntario).HasName("PK__Encargad__A346463B8A9647FF");

            entity.ToTable("Encargado_voluntario");

            entity.Property(e => e.IdEncargadoVoluntario).HasColumnName("Id_encargado_voluntario");
            entity.Property(e => e.FechaFinal).HasColumnName("Fecha_final");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_inicio");
            entity.Property(e => e.IdDetalleProfesionalVoluntario).HasColumnName("Id_detalle_profesional_voluntario");
            entity.Property(e => e.IdVoluntarioEncargado).HasColumnName("Id_voluntario_encargado");

            entity.HasOne(d => d.IdDetalleProfesionalVoluntarioNavigation).WithMany(p => p.EncargadoVoluntarios)
                .HasForeignKey(d => d.IdDetalleProfesionalVoluntario)
                .HasConstraintName("FK__Encargado__Id_de__6A30C649");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("PK__Eventos__D44FA6DE32A0C28C");

            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.EmpresaEvento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Empresa_evento");
            entity.Property(e => e.EncargadoEmpresaEvento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Encargado_empresa_evento");
            entity.Property(e => e.EstadoEvento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Estado_evento");
            entity.Property(e => e.FechaHoraEvento).HasColumnName("Fecha_hora_evento");
            entity.Property(e => e.LugarRealizacionEvento)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Lugar_realizacion_evento");
            entity.Property(e => e.NombreEvento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_evento");
            entity.Property(e => e.NumeroInvitados).HasColumnName("Numero_invitados");
            entity.Property(e => e.TelefonoEncargadoEmpresaEvento).HasColumnName("Telefono_encargado_empresa_evento");
        });

        modelBuilder.Entity<ExistenciaAcudiente>(entity =>
        {
            entity.HasKey(e => e.IdExAc).HasName("PK__Existenc__3CC856199E9F0230");

            entity.ToTable("Existencia_Acudientes");

            entity.Property(e => e.IdExAc).HasColumnName("Id_Ex_Ac");
            entity.Property(e => e.FechaFinalAcudiente)
                .HasColumnType("date")
                .HasColumnName("Fecha_Final_Acudiente");
            entity.Property(e => e.FechaInicioAcudiente)
                .IsRowVersion()
                .IsConcurrencyToken()
                .HasColumnName("Fecha_Inicio_Acudiente");
            entity.Property(e => e.IdAcudiente).HasColumnName("Id_Acudiente");
            entity.Property(e => e.IdBeneficiario).HasColumnName("Id_Beneficiario");
        });

        modelBuilder.Entity<HistoriaClínica>(entity =>
        {
            entity.HasKey(e => e.IdHistoriaClinica).HasName("PK__Historia__2EDC8FE26259DC90");

            entity.ToTable("Historia_Clínica");

            entity.Property(e => e.IdHistoriaClinica).HasColumnName("Id_HistoriaClinica");
            entity.Property(e => e.ApellidosAcudiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Apellidos_Acudiente");
            entity.Property(e => e.ApellidosBeneficiario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Apellidos_Beneficiario");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("Fecha_Creacion");
            entity.Property(e => e.NombreAcudiente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Acudiente");
            entity.Property(e => e.NombreBeneficiario)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_Beneficiario");
            entity.Property(e => e.NroDocumento).HasColumnName("Nro_Documento");
            entity.Property(e => e.NroDocumentoAcudiente).HasColumnName("Nro_Documento_Acudiente");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Tipo_Documento");
            entity.Property(e => e.TipoDocumentoAcudiente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_Documento_Acudiente");
        });

        modelBuilder.Entity<Medicamento>(entity =>
        {
            entity.HasKey(e => e.IdMedicamento).HasName("PK__Medicame__391D9D47E5B9C9B6");

            entity.Property(e => e.IdMedicamento).HasColumnName("Id_medicamento");
            entity.Property(e => e.Gramage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreMedicamento)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("Nombre_medicamento");
            entity.Property(e => e.NumeroGramage).HasColumnName("Numero_gramage");
            entity.Property(e => e.StockMedicamento).HasColumnName("Stock_Medicamento");
            entity.Property(e => e.TipoCantidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Tipo_Cantidad");
        });

        modelBuilder.Entity<Participante>(entity =>
        {
            entity.HasKey(e => e.IdParticipantes).HasName("PK__Particip__7C5F5C4D59321728");

            entity.Property(e => e.IdParticipantes).HasColumnName("Id_participantes");
            entity.Property(e => e.ApellidoParticipante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Apellido_participante");
            entity.Property(e => e.AsistenciaParticipante).HasColumnName("Asistencia_participante");
            entity.Property(e => e.DocumentoParticipante).HasColumnName("Documento_participante");
            entity.Property(e => e.EdadParticipante).HasColumnName("Edad_participante");
            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.NombreParticipante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_participante");
            entity.Property(e => e.PlacaVehiculoPersonalParticipantes)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Placa_vehiculo_personal_participantes");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_documento");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.IdEvento)
                .HasConstraintName("FK__Participa__Id_ev__75A278F5");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Participantes)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Participa__Id_us__76969D2E");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__DB05CEDBD9086636");

            entity.Property(e => e.IdProducto).HasColumnName("id_Producto");
            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion_Producto");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_Categoria");
            entity.Property(e => e.NombreEstado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_Estado");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre_Producto");
            entity.Property(e => e.PrecioProducto).HasColumnName("precio_Producto");

            entity.HasOne(d => d.NombreCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.NombreCategoria)
                .HasConstraintName("FK__Productos__nombr__2739D489");

            entity.HasOne(d => d.NombreEstadoNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.NombreEstado)
                .HasConstraintName("FK__Productos__nombr__282DF8C2");
        });

        modelBuilder.Entity<ProductosEstado>(entity =>
        {
            entity.HasKey(e => e.NombreEstado).HasName("PK__producto__FC7035E386DF542C");

            entity.ToTable("productos_Estados");

            entity.Property(e => e.NombreEstado)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("nombre_Estado");
            entity.Property(e => e.IdEstadoProductos)
                .ValueGeneratedOnAdd()
                .HasColumnName("id_Estado_Productos");
        });

        modelBuilder.Entity<ProfesionalesVoluntario>(entity =>
        {
            entity.HasKey(e => e.IdVoluntario).HasName("PK__Profesio__972756F21EB8537F");

            entity.ToTable("Profesionales_voluntarios");

            entity.Property(e => e.IdVoluntario).HasColumnName("Id_voluntario");
            entity.Property(e => e.EstadoVoluntario)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Estado_voluntario");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro");
            entity.Property(e => e.IdRol).HasColumnName("Id_rol");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.NombreProfesional)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_profesional");
            entity.Property(e => e.NumeroDocumento).HasColumnName("Numero_documento");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_documento");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.ProfesionalesVoluntarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Profesion__Id_ro__5DCAEF64");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ProfesionalesVoluntarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Profesion__Id_us__5EBF139D");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Roles__2D95A894023CAF41");

            entity.Property(e => e.IdRol).HasColumnName("Id_rol");
            entity.Property(e => e.Rol)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RolesDeUsuario>(entity =>
        {
            entity.HasKey(e => e.IdRolUsuario).HasName("PK__RolesDeU__0748B91FDD5ECA0F");

            entity.Property(e => e.IdRolUsuario).HasColumnName("Id_rol_Usuario");
            entity.Property(e => e.IdRol).HasColumnName("Id_rol");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolesDeUsuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__RolesDeUs__Id_ro__6E01572D");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.RolesDeUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__RolesDeUs__Id_us__6D0D32F4");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__A8B83B4D63EB820E");

            entity.Property(e => e.IdServicio).HasColumnName("Id_servicio");
            entity.Property(e => e.DisponibilidadServicio).HasColumnName("Disponibilidad_servicio");
            entity.Property(e => e.FechaRegistroServicio)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("Fecha_registro_servicio");
            entity.Property(e => e.IdCategoriaServicio).HasColumnName("Id_categoria_servicio");
            entity.Property(e => e.NombreServicio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_servicio");

            entity.HasOne(d => d.IdCategoriaServicioNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.IdCategoriaServicio)
                .HasConstraintName("FK__Servicios__Id_ca__4D94879B");
        });

        modelBuilder.Entity<TipoProfesional>(entity =>
        {
            entity.HasKey(e => e.IdTipoProfesional).HasName("PK__Tipo_pro__B7F97B0B0A3DD2CF");

            entity.ToTable("Tipo_profesional");

            entity.Property(e => e.IdTipoProfesional).HasColumnName("Id_tipo_profesional");
            entity.Property(e => e.NombreTipoprofesional)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_tipoprofesional");
        });

        modelBuilder.Entity<TipoVoluntario>(entity =>
        {
            entity.HasKey(e => e.IdTipoVoluntario).HasName("PK__Tipo_vol__96C19A835FE98868");

            entity.ToTable("Tipo_voluntario");

            entity.Property(e => e.IdTipoVoluntario).HasColumnName("Id_tipo_voluntario");
            entity.Property(e => e.NombreTipoVoluntario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_tipo_voluntario");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__EF59F762E25D7838");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.ContraseñaUsuario)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Contraseña_usuario");
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Correo_electronico");
            entity.Property(e => e.Estado)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IdRol).HasColumnName("Id_rol");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_usuario");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Usuarios__Id_rol__59FA5E80");
        });

        modelBuilder.Entity<VehiculosContratado>(entity =>
        {
            entity.HasKey(e => e.IdVc).HasName("PK__Vehiculo__16EC2989DB299437");

            entity.ToTable("Vehiculos_contratados");

            entity.Property(e => e.IdVc).HasColumnName("Id_VC");
            entity.Property(e => e.CapacidadVc).HasColumnName("Capacidad_VC");
            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.PlacaVc)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Placa_VC");
            entity.Property(e => e.TipoVc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_VC");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.VehiculosContratados)
                .HasForeignKey(d => d.IdEvento)
                .HasConstraintName("FK__Vehiculos__Id_ev__5535A963");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
