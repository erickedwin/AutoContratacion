using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoContratacion.Models
{
    [Table("t_reglas")]
    public class IntermediaMensaje
    {
        [Key]
        public int id {get; set;}
        public string? codigo {get; set;}
        public string regla {get; set;}
    }
}