using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T2_QuispeJose.Models
{
    public class Distribuidor
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El año debe ser entre 1900 - 3000")]
        public int AnioInicioOperacion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Contacto { get; set; }
    }
}
