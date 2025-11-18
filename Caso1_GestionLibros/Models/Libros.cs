using System.ComponentModel.DataAnnotations;

namespace Caso1_GestionLibros.Models
{
    public class Libros
    {
        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "El título debe tener entre 3 y 200 caracteres.")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El autor es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El autor debe tener entre 3 y 100 caracteres.")]
        public string Autor { get; set; } = string.Empty;

        [Required(ErrorMessage = "La categoría es obligatoria.")]
        public string Categoria { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año de publicación es obligatorio.")]
        [Range(1900, 2025, ErrorMessage = "El año debe estar entre 1900 y el año actual.")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El número de páginas es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de páginas debe ser mayor que 0.")]
        public int NumeroPaginas { get; set; }

        [Required(ErrorMessage = "El código interno es obligatorio.")]
        [RegularExpression(@"^LIB-\d{3,}$", ErrorMessage = "El código debe seguir el formato LIB-### (ej. LIB-001).")]
        public string CodigoInterno { get; set; } = string.Empty;

        [Required(ErrorMessage = "La disponibilidad es obligatoria.")]
        public bool Disponible { get; set; }
    } //class
} //end
