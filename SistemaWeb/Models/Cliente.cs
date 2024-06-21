using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Ci { get; set; }
        [Required, MinLength(4), MaxLength(50)]
        public string? Nombre { get; set; }
        public int Telefono { get; set; }

        //Relaciones 1 ----> *
        public virtual List<Alquiler>? Alquilers { get; set; }
    }
}
