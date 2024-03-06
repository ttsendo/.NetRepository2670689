using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectef.Models;

public class Tarea{
    // [Key]
    public Guid tareaId{get;set;}
    // [Required]
    // [MaxLength(150)]
    public Guid categoriaId{get;set;}
    public string titulo {get;set;}
    public string descripcion {get;set;}
    public Prioridad prioridadTarea{get;set;}
    public DateTime fechaCreacion{get;set;}
    public virtual Categoria categoria {get;set;}
    [NotMapped]
    public string resumen {get;set;}

}

public enum Prioridad{
    baja,
    media,
    alta
}