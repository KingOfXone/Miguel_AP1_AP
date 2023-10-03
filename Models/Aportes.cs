using System.ComponentModel.DataAnnotations;

namespace Miguel_AP1_AP.Models
{
    public class Aportes
    {
        
        [Key]
        public int AportesId { get; set; }
        [Required(ErrorMessage = "Fecha es requerido")]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Persona es requerido")]
        public string? Persona { get; set; }
        [Required(ErrorMessage = "El monto es requerido")]
        public decimal Monto { get; set; }

        public string? Observacion { get; set; }
    }
}
