using System.ComponentModel.DataAnnotations;

namespace EstudiantesBlazorProyecto.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombres es obligatorio")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El campo Apellidos es obligatorio")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria")]
        public DateTime FechaNacimiento { get; set; } = DateTime.Now.AddYears(-18); // Valor por defecto: 18 años atrás

        [Required(ErrorMessage = "La dirección es obligatoria")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El sexo es obligatorio")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "El CURP es obligatorio")]
        [StringLength(18, ErrorMessage = "El CURP debe tener 18 caracteres")]
        public string CURP { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [Phone(ErrorMessage = "Formato de teléfono inválido")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El email es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La carrera es obligatoria")]
        public string Carrera { get; set; }

        [Display(Name = "¿Es becado?")]
        public bool EsBecado { get; set; }

        [Required(ErrorMessage = "La modalidad es obligatoria")]
        public string Modalidad { get; set; }

        // Campos opcionales (igual que en tu BD)
        // Campos opcionales (agrega "?" para nullable)
        public string? DescripcionPersonal { get; set; }
        public string? TipoMascotas { get; set; }
        public string? HorarioComida { get; set; }
    
        // El campo BIT no necesita ser nullable
        public bool TieneMascotas { get; set; }
    }
}