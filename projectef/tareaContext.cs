using Microsoft.EntityFrameworkCore;
using projectef.Models;
namespace projectef;


public class tareaContext:DbContext
{
    public DbSet<Categoria> Categorias {get;set;}
    public DbSet<Tarea> tareas {get;set;}

    public tareaContext (DbContextOptions <tareaContext> options):base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria> (categoria=>
        {

        categoria.ToTable("categoria");
        categoria.HasKey(p => p.categoriaId);
        categoria.Property(p=>p.descripcion).IsRequired().HasMaxLength(150);
        categoria.Property(p=>p.descripcion);

    });

    modelBuilder.Entity<Tarea>(tarea => {
        tarea.ToTable("Tarea");
        tarea.HasKey(p=>p.tareaId);
        tarea.HasOne(p=>p.categoria).WithMany(p=>p.tareas).HasForeignKey(p=>p.categoriaId);
        tarea.Property(p=>p.titulo).IsRequired().HasMaxLength(200);
        tarea.Property(p=>p.prioridadTarea);
        tarea.Property(p=>p.fechaCreacion);
        tarea.Ignore(p=>p.resumen);// no guardar en BD

    });
    }
}
