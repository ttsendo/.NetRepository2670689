using System.ComponentModel.DataAnnotations;

namespace projectef.Models;

public class Categoria{
    //atributos generales del modelo
    // [Key]
    public Guid categoriaId{get;set;}
    // [Required]
    // [MaxLength(150)]
    public string nombre{get;set;}
    public string descripcion{get;set;}

    public virtual ICollection<Tarea> tareas {get;set;}
    //public virtual permite establecer connecion entre los dos modelos
}
