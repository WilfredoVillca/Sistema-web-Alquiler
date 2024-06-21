using SistemaWeb.Controllers.Dto;
using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Usuario
    {
        [Key]//Annotations
        public int Id { get; set; }
        [Required, MinLength(4), MaxLength(50)]
        public string? Email { get; set; }
        [Required, MinLength(4), MaxLength(20)]
        public string? Password { get; set; }
        [Required, MinLength(4), MaxLength(50)]
        public string? Nombre { get; set; }
        [Required]
        public RolEnum Rol { get; set; }

        //Relaciones 1 ----> *
        public virtual List<Alquiler>? Alquilers { get; set; }
    }
}
