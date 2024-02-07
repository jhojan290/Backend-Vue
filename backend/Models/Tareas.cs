using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Tareas
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]

        public string Nombre { get; set; }

        [Required]

        public bool Estado { get; set; }
    }
}
