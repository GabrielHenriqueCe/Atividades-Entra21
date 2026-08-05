using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Curso
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "A carga horária é obrigatória.")]
        [Range(1, 500, ErrorMessage = "A carga horária deve estar entre 1 e 500 horas.")]
        public int CargaHoraria { get; set; }
    }
}