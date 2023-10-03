using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Miguel_AP1_AP.Models
    public class AportesBll
{

    [Required(ErrorMessage = "El AportesId es requerido")]
    public int AportesId { get; set; }
    [Required(ErrorMessage = "Persona es requerido")]
    public string? Titulo { get; set; }
    [Required(ErrorMessage = "El monto es requerido")]
    public double aporte { get; set; }
}

}