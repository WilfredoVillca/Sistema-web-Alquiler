using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaWeb.Models
{
    public class Cancha
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        public int Numero_Cancha { get; set; }

        public string? Foto { get; set; } //almacenar la ubicación de fotos
        //Cargar Foto
        [NotMapped] //No va migrar en BdD
        [Display(Name = "Cargar Foto")]
        public IFormFile? FotoFile { get; set; }

        //atributos computados
        [NotMapped]
        public string? InfoCanchaNum { get { return $"{Numero_Cancha}"; } }
        public string? InfoCanchaCap { get { return $"{Capacidad}"; } }

        //Relaciones 1 ----> *
        public virtual List<Alquiler>? Alquilers { get; set; }
    }
}
