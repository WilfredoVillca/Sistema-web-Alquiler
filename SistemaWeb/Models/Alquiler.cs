using SistemaWeb.Controllers.Dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWeb.Models
{
    public class Alquiler
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Numero_Recibo { get; set; }
        [Column(TypeName = "date")]
        public DateTime Fecha { get; set; }
        [Required]
        public int Cantidad_Hora { get; set; }
      
        public DateTime Desde { get; set; }
       
        public DateTime Hasta { get; set; }
        [Required]
        public decimal Costo_Total { get; set; }
       public RolEstado Estado { get; set; }

        //Relaciones * -----> 1
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public int CanchaId { get; set; }

        public virtual Usuario? Usuario { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Cancha? Cancha { get; set; }
    }
}
