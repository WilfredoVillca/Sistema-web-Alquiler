using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        //atributos computados
        [NotMapped]
        public string? InfoClienteCI { get { return $"{Ci}"; } }
        public string? InfoClienteNombre { get { return $"{Nombre}"; } }
        public string? InfoClienteTelefono { get { return $"{Telefono}"; } }

        //Relaciones 1 ----> *
        public virtual List<Alquiler>? Alquilers { get; set; }
    }
}
