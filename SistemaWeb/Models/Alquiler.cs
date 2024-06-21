using System.ComponentModel.DataAnnotations;

namespace SistemaWeb.Models
{
    public class Alquiler
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Numero_Recibo { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public DateTime Desde { get; set; }
        [Required]
        public DateTime Hasta { get; set; }
        [Required]
        public decimal Costo_Total { get; set; }

        //Relaciones * -----> 1
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public int CanchaId { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Cancha? Cancha { get; set; }
    }
}
