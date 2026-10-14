using System.ComponentModel.DataAnnotations;

namespace LAB09.Models
{
    public class Alumno
    {
        public int Id { get; set; }

        [Display(Name = "Nombres completos")]
        [Required(ErrorMessage = "Los nombres son obligatorios")]
        public string Nombres { get; set; } = string.Empty;

        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Correo no válido")]
        public string Correo { get; set; } = string.Empty;

        [Required(ErrorMessage = "La clave es obligatoria")]
        [MinLength(4, ErrorMessage = "Mínimo 4 caracteres")]
        public string Clave { get; set; } = string.Empty;

        [Required(ErrorMessage = "Seleccione una carrera")]
        public string Carrera { get; set; } = string.Empty;

        [Required(ErrorMessage = "Seleccione un turno")]
        public string Turno { get; set; } = string.Empty;

        public bool Becado { get; set; }

        public string? Observaciones { get; set; }
    }
}
